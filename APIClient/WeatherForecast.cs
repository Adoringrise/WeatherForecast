using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace APIClient
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        [Required]
        public int? TemperatureC { get; set; }

        public string? Summary { get; set; }

        public string? WeatherEvent { get; set; }

    }
}