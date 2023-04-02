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
            var weatherForecast = new WeatherForecastApi("https://localhost:7016/");

            var result = await weatherForecast.GetWeatherForecastList();

            foreach (var item in result)
            {
                Console.WriteLine(item.Summary);
            }


            var localImpact = await weatherForecast.GetLocalImpactList();

            foreach (var item in localImpact)
            {
                Console.WriteLine(item.Location);
            }
        }
    }
}