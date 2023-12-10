using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaxesCalculator.Models.Models
{
    public class TaxesCalculationRequest
    {
        [Required(ErrorMessage = "Salary should be filled")]
        [Range(0, double.MaxValue, ErrorMessage = "Sallary should be positive")]
        public double Salary { get; set; }
    }
}
