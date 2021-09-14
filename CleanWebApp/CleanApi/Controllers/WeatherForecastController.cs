using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanApi.Models;
using CleanApi.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace CleanApi.Controllers
{
    public class WeatherForecastController : BaseController<WeatherForecastController>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(ILogger<WeatherForecastController> logger) : base(logger)
        {

        }

        [SwaggerOperation(Summary = "Get Weather")]
        [HttpGet(nameof(Get))]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [ActionName("ShowAllOtherName")]
        [SwaggerOperation(Summary = "ShowAll")]
        [HttpPost(nameof(ShowAll))]
        public IActionResult ShowAll()
        {
            var result = new SomeModel
            {
                Id = 0,
                Name = "Name 1",
                Model = "Model 1"
            };
            return Ok(result);
        }

        [SwaggerOperation(Summary = "ShowAll")]
        [HttpPost(nameof(AnotherMethod))]
        public IActionResult AnotherMethod([FromBody] SomeDto dto)
        {
            var result = new SomeModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Model = "Model 1"
            };
            return Ok(result);
        }
    }
}