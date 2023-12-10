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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TaxesController> _logger;
        private readonly ITaxesService _taxesService;

        public TaxesController(ILogger<TaxesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public TaxesCalculationResult Get(TaxesCalculationRequest model)
        {
            return _taxesService.Calculate(model);
        }
    }
}
