using APIClient;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProductStoreClient
{
    static class Constants
    {

        public const string ApiUrl = "https://localhost:7016/";
        public const string WeatherForecastEndpointName = "WeatherForecast";
        public const string localImpactEndpointName = "localImpact";
    }
    class Program
    {
        static async Task Main()
        {
            var weatherForecastApi = new WeatherForecastApi(Constants.ApiUrl);

            var weatherForecast = await weatherForecastApi.Get<List<WeatherForecast>>(Constants.WeatherForecastEndpointName);

            var localImpact = await weatherForecastApi.Get<List<LocalImpact>>(Constants.localImpactEndpointName);

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