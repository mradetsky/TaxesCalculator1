using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxesCalculator.Models.Models;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.BLL.Services
{
    public interface ITaxesService
    {
        public Task<TaxesCalculationResult> CalculateAsync(TaxesCalculationRequest request);
    }
}
