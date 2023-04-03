using Microsoft.AspNetCore.Mvc;

namespace NovoFluxoGit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeatureBController : ControllerBase
    {
        private string _featureF = "FeatureF";
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "FeatureE", "FeatureF"
        };

        private readonly ILogger<FeatureBController> _logger;

        public FeatureBController(ILogger<FeatureBController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "FeatureB")]
        public IEnumerable<WeatherForecast> FeatureB()
        {
            string featureE = "featureE";

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = featureE
            })
            .ToArray();
        }
    }
}