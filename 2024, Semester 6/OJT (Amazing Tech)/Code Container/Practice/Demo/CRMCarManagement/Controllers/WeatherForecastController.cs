using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using Ilogger = Serilog.ILogger;

namespace CRMCarManagement.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //private readonly ILogger<WeatherForecastController> _logger;
        private readonly Ilogger _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}
        public WeatherForecastController()
        {
            _logger = Log.Logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        [HttpGet()]
        [Route("[controller]/thoi-tiet")]

        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        public IEnumerable<WeatherForecast> Get()
        {
            _logger.Information("Start Getting thoi-tiet...");
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
