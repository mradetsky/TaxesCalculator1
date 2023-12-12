using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxesCalculator.BLL.Services;
using TaxesCalculator.Models.Enums;
using TaxesCalculator.Models.Models;
using TaxesCalculator.Models.Results;

namespace TaxesCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxesController : ControllerBase
    {
        

        private readonly ILogger<TaxesController> _logger;
        private readonly ITaxesService _taxesService;

        public TaxesController(ITaxesService taxesService, ILogger<TaxesController> logger)
        {
            _taxesService = taxesService;
            _logger = logger;
        }

        [HttpPost]
        public Task<TaxesCalculationResult> PostAsync(TaxesCalculationRequest model)
        {
            return _taxesService.CalculateAsync(model);
        }
    }
}
