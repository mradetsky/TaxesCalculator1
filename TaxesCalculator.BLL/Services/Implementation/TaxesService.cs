using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxesCalculator.BLL.Extensions;
using TaxesCalculator.DAL.Repositories;
using TaxesCalculator.Models.Models;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.BLL.Services.Implementation
{
    public class TaxesService : ITaxesService
    {
        private readonly IBandRepository _bandRepository;
        
        public TaxesService(IBandRepository bandRepository)
        {
            this._bandRepository = bandRepository;
        }
        public TaxesCalculationResult Calculate(TaxesCalculationRequest request)
        {
            var bands = this._bandRepository.GetAll().Where(x => x.IsActive);
            bands.ValidateBands();
            var taxes = bands.Sum(x => x.CalculateBandTaxes(request.Salary));
            
            
            return new TaxesCalculationResult(request.Salary, taxes);
        }
    }
}
