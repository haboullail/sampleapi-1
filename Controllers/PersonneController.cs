using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;

        public PersonneController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personne = new string[]{

                "HAMZA",
                "HOUDI",
                "HABOU",
                "PER"

            };
            return Ok(personne);
        }
    }
}
