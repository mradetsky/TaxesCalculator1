using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.BLL.Services
{
    public interface ITaxesService
    {
        public List<TaxesCalculationResult> Calculate(double salary);
    }
}
