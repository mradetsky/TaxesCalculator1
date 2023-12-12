
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using TaxesCalculator.BLL.Extensions;
using TaxesCalculator.BLL.Services;
using TaxesCalculator.BLL.Services.Implementation;
using TaxesCalculator.DAL.Entities;
using TaxesCalculator.DAL.Repositories.Implementation;
using TaxesCalculator.Tests.Fake;
using TaxesCalculator.Tests.TestModels;

namespace TaxesCalculator.Tests.Tests
{
    public class TaxesCalculationTest
    {
        private ITaxesService _taxesService;
        [SetUp]
        public void Setup()
        {
            _taxesService = new TaxesService(new BandRepositoryFake()); // TODO : implement DI
        }

        public static List<object[]> TestCases = new List<object[]>()
            {
                new object[]{
                    10000,
                    new CalculationResultTest()
                    {
                        GrossAnnualSalary = 10000,
                        GrossMonthlySalary = 833.33333333333337d,
                        NetAnnualSalary = 9000,
                        NetMonthlySalary = 9000/12,
                        AnnualTaxPaid = 1000,
                        MonthlyTaxPaid = 83.333333333333329d
                    }
                },
                new object[]{
                    40000,
                    new CalculationResultTest()
                    {
                        GrossAnnualSalary = 40000,
                        GrossMonthlySalary = 3333.3333333333335d,
                        NetAnnualSalary = 29000,
                        NetMonthlySalary = 2416.6666666666665,
                        AnnualTaxPaid = 11000,
                        MonthlyTaxPaid = 916.66666666666663d
                    }
                },
            };


        [Test]
        [TestCaseSource(nameof(TestCases))]

        public async Task TestCalculations(double salary, CalculationResultTest result)
        {
            var res = await _taxesService.CalculateAsync(new Models.Models.TaxesCalculationRequest()
            {
                Salary = salary
            });

            Assert.AreEqual(result.GrossAnnualSalary, res.GrossAnnualSalary, $"Error for salary: {salary}");
            Assert.AreEqual(result.GrossMonthlySalary, res.GrossMonthlySalary, $"Error for salary: {salary}");
            Assert.AreEqual(result.NetAnnualSalary, res.NetAnnualSalary, $"Error for salary: {salary}");
            Assert.AreEqual(result.NetMonthlySalary, res.NetMonthlySalary, $"Error for salary: {salary}");
            Assert.AreEqual(result.AnnualTaxPaid, res.AnnualTaxPaid, $"Error for salary: {salary}");
            Assert.AreEqual(result.MonthlyTaxPaid, res.MonthlyTaxPaid, $"Error for salary: {salary}");
        }
    }
}