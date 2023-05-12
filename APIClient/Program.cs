using APIClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace APIClient
{
    class Program
    {
        const string WeatherForecastEndpointName = "/WeatherForecast";
        const string localImpactEndpointName = "/localImpact";

        static async Task Main()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false);

            IConfiguration config = builder.Build();

            var apiUrl = config["apiUrl"];

            var weatherForecastApi = new WeatherForecastApi(apiUrl);

            var weatherForecast = await weatherForecastApi.Get<List<WeatherForecast>>(WeatherForecastEndpointName);

            var localImpact = await weatherForecastApi.Get<List<LocalImpact>>(localImpactEndpointName);

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