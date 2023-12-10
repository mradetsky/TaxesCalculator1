using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.Tests.TestModels
{
    public class CalculationResultTest
    {
        public double GrossAnnualSalary { get; set; }

        public double GrossMonthlySalary { get; set; }

        public double NetAnnualSalary { get; set; }

        public double NetMonthlySalary { get; set; }

        public double AnnualTaxPaid { get; set; }

        public double MonthlyTaxPaid { get; set; }

    }
}
