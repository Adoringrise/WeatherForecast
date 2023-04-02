using APIClient;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProductStoreClient
{
    class Program
    {
        static async Task Main()
        {
            var weatherForecastApi = new WeatherForecastApi("https://localhost:7016/");

            var weatherForecast = await weatherForecastApi.Get<List<WeatherForecast>>("WeatherForecast");

            var localImpact = await weatherForecastApi.Get<List<LocalImpact>>("localImpact");

            foreach (var item in weatherForecast)
            {
                Console.WriteLine(item.Summary);
            }

            foreach (var item in localImpact)
            {
                Console.WriteLine(item.LocationDamage);
            }
        }
    }
}