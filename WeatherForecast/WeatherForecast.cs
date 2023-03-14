using System.ComponentModel.DataAnnotations;

namespace WeatherForecast
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        [Required]
        public int? TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}