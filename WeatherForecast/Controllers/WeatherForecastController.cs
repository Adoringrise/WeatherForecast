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


        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return WeatherForecast;
        }



        [HttpPost]
        public List<WeatherForecast> Insert(List<WeatherForecast> weather)
        {
            WeatherForecast.AddRange(weather);
            return weather;
        }
    }
}