using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using ILogger = Serilog.ILogger;

namespace CRMBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger _logger;

        public WeatherForecastController()
        {
            _logger = Log.Logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.Information("Start get Thoi_tiet: ");
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
            var dataJson = JsonConvert.SerializeObject(data);
            _logger.Information(dataJson);

            return data;


        }
    }
}