using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.BLL.Services.Implementation
{
    public class TaxesService : ITaxesService
    {
        public List<TaxesCalculationResult> Calculate(double salary)
        {
            return new List<TaxesCalculationResult>();
        }
    }
}
