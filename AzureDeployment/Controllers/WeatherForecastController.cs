using Microsoft.AspNetCore.Mvc;

namespace AzureDeployment.Controllers
{
    [ApiController]
    [Route("/")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
