using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.Models.Models;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.BLL.Services
{
    public interface ITaxesService
    {
        public TaxesCalculationResult Calculate(TaxesCalculationRequest request);
    }
}
