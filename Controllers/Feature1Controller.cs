using Microsoft.AspNetCore.Mvc;

namespace NovoFluxoGit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Feature1Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching", "Feature/G", "HotFixA"
        };

        private readonly ILogger<Feature1Controller> _logger;

        public Feature1Controller(ILogger<Feature1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Feature1")]
        public IEnumerable<WeatherForecast> Feature1()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "FeatureG")]
        public IEnumerable<WeatherForecast> FeatureG()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}