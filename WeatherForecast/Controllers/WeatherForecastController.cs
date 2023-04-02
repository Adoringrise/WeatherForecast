using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        static List<WeatherForecast> WeatherForecast = new();

        static List<LocalImpact> LocalImpacts = new();


        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return WeatherForecast;
        }

        [HttpGet("/localImpact")]
        public IEnumerable<LocalImpact> GetLocationDamage()
        {
            return LocalImpacts;
        }



        [HttpPost]
        public List<WeatherForecast> Insert(List<WeatherForecast> weather)
        {
            WeatherForecast.AddRange(weather);
            return weather;
        }
        
        [HttpPost("/localImpact")]
        public List<LocalImpact> Insert(List<LocalImpact> location)
        {
            LocalImpacts.AddRange(location);
            return location;
        }
    }
}