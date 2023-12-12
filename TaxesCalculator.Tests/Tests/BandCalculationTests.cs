
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaxesCalculator.BLL.Extensions;
using TaxesCalculator.DAL.Entities;


namespace TaxesCalculator.Tests.Tests
{
    public class BandCalculationTests
    {
        [SetUp]
        public void Setup()
        {

        }

        public static List<object[]> TestCases = new List<object[]>()
            {
                new object[]{
                    new Band(){Id= 1, SalaryRangeTo = 100, TaxRate = 5}, 50, 2.5
                },
                new object[]{
                    new Band(){Id= 2, SalaryRangeTo = 100, TaxRate = 5}, 150, 5
                },
                new object[]{
                    new Band(){Id= 3, SalaryRangeFrom = 50, SalaryRangeTo = 100, TaxRate = 5}, 45, 0
                },
                new object[]{
                    new Band(){Id= 4, SalaryRangeFrom = 50, SalaryRangeTo = 100, TaxRate = 5}, 75, 1.25
                },
                new object[]{
                    new Band(){Id= 5, SalaryRangeFrom = 50, SalaryRangeTo = 100, TaxRate = 5}, 151, 2.5
                },
                new object[]{
                    new Band(){Id= 6, SalaryRangeFrom = 50, TaxRate = 20}, 50, 0
                },
                new object[]{
                    new Band(){Id= 7, SalaryRangeFrom = 50, TaxRate = 20}, 75, 5
                },

                //salary 10000
                new object[]{
                    new Band(){Id= 8, SalaryRangeTo = 5000, TaxRate = 0}, 10000, 0
                },
                new object[]{
                    new Band(){Id= 9, SalaryRangeFrom = 5000, SalaryRangeTo = 20000, TaxRate = 20}, 10000, 1000
                },
                new object[]{
                    new Band(){Id= 10, SalaryRangeFrom = 10000, TaxRate = 40}, 10000, 0
                },
                //salary 20000
                new object[]{
                    new Band(){Id= 11, SalaryRangeTo = 5000, TaxRate = 0}, 40000, 0
                },
                new object[]{
                    new Band(){Id= 12, SalaryRangeFrom = 5000, SalaryRangeTo = 20000, TaxRate = 20}, 40000, 3000
                },
                new object[]{
                    new Band(){Id= 13, SalaryRangeFrom = 10000, TaxRate = 40}, 40000, 12000
                },
            };


        [Test]
        [TestCaseSource(nameof(TestCases))]

        public void TestCalculations(Band band, double salary, double result)
        {
            var res = band.CalculateBandTaxes(salary);
            Assert.AreEqual(result, res, $"Band id:{band.Id}");
        }
    }
}