using EntityCodeFirstExamLib;
using Microsoft.AspNetCore.Mvc;

namespace LearnApi.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly SchoolContext schoolContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, SchoolContext schoolContext)
        {
            _logger = logger;
            this.schoolContext = schoolContext;    
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("getGrades")]
        public IActionResult GetGrades()
        {
            var grades = schoolContext.Grades.ToList();
            return Ok(grades);
        }
        [HttpPost("testPostMethod")]
        public IActionResult TestPostMethod(WeatherForecast data) {
            return Ok();
        }
        [HttpPost("testPutMethod")]
        public IActionResult TestPutMethod()
        {
            return Ok();
        }
        [HttpGet("testDeleteMethod/{count}")]
        public IActionResult TestDeleteMethod(int count)
        {
            return Ok(count*2);
        }
    }
}