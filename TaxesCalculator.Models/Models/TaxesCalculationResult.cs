using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Enums;

namespace TaxesCalculator.Models.Results
{
    public class TaxesCalculationResult
    {
        public TaxesCalculationResult(double salary, double taxes)
        {
            this.GrossAnnualSalary = salary;
            this.AnnualTaxPaid = taxes;
        }
        
        public double GrossAnnualSalary { get; set; }

        public double GrossMonthlySalary { get { return GrossAnnualSalary / 12; } }

        public double NetAnnualSalary { get { return GrossAnnualSalary - AnnualTaxPaid; } }

        public double NetMonthlyAnnualSalary { get { return NetAnnualSalary / 12; } }

        public double AnnualTaxPaid { get; set; }

        public double MonthlyTaxPaid { get { return AnnualTaxPaid / 12; } }
        
}
}
