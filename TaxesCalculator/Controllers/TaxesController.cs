using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxesCalculator.Models.Enums;
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

        public TaxesController(ILogger<TaxesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaxesCalculationResult> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TaxesCalculationResult
            {
                Result = rng.Next(-20, 55),
                ResultType = (ResultType)rng.Next(0, 5)
            })
            .ToArray();
        }
    }
}
