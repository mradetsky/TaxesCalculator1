using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaxesCalculator.Models.Enums
{
    public enum ResultType
    {
        [Display(Name = "Gross Annual Salary")]
        GrossAnnualSalary,
        [Display(Name = "Gross Monthly Salary")]
        GrossMonthlySalary,
        [Display(Name = "Net Annual Salary")]
        NetAnnualSalary,
        [Display(Name = "Net Monthly Salary")]
        NetMonthlySalary,
        [Display(Name = "Annual Tax Paid")]
        AnnualTaxPaid,
        [Display(Name = "Monthly Tax Paid")]
        MonthlyTaxPaid
    }
}
