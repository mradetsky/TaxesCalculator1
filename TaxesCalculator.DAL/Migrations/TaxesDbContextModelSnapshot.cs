﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxesCalculator.DAL;

#nullable disable

namespace TaxesCalculator.DAL.Migrations
{
    [DbContext(typeof(TaxesDbContext))]
    partial class TaxesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaxesCalculator.DAL.Entities.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("SalaryRangeFrom")
                        .HasColumnType("int");

                    b.Property<int?>("SalaryRangeTo")
                        .HasColumnType("int");

                    b.Property<double>("TaxRate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "Band A",
                            Order = 1,
                            SalaryRangeTo = 5000,
                            TaxRate = 0.0
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "Band B",
                            Order = 2,
                            SalaryRangeFrom = 5000,
                            SalaryRangeTo = 20000,
                            TaxRate = 20.0
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "Band C",
                            Order = 3,
                            SalaryRangeFrom = 20000,
                            TaxRate = 40.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
