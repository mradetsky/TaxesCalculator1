using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TaxesCalculator.DAL.Entities;

namespace TaxesCalculator.DAL
{
    public class TaxesDbContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }

        public TaxesDbContext(DbContextOptions<TaxesDbContext> dbContextOptions)   : base(dbContextOptions) 
        {
            
        }
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(
               new Band() { Id = 1, Order = 1, Name = "Band A", SalaryRangeFrom = null, SalaryRangeTo = 5000, TaxRate = 0, IsActive = true },
               new Band() { Id = 2, Order = 2, Name = "Band B", SalaryRangeFrom = 5000, SalaryRangeTo = 20000, TaxRate = 20, IsActive = true },
               new Band() { Id = 3, Order = 3, Name = "Band C", SalaryRangeFrom = 20000, SalaryRangeTo = null, TaxRate = 40, IsActive = true }
            );
            base.OnModelCreating(modelBuilder);
        }
        protected virtual void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}
