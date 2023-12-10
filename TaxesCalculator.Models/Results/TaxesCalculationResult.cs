using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Enums;

namespace TaxesCalculator.Models.Results
{
    public class TaxesCalculationResult
    {
        public ResultType ResultType { get;set; }
        public double Result { get; set; }
    }
}
