using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WMIController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WMIController> _logger;

        public WMIController(ILogger<WMIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WMIDTOOld> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WMIDTOOld
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet, Route("getUserById/{id}")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var data = "something" + id;
            return Ok(new
            {
                thisIsAnonymous = true,
                user = data
            });
        }

        [HttpGet, Route("getUserByIdv2/{id}")]
        public async Task<IActionResult> GetUserByIDv2(int id)
        {
            var person = new { Age = 10+id, Name = "John", Address = "Miami", id };
            return Ok(new
            {
                thisIsAnonymous = true,
                user = person
            });
        }
    }
}

