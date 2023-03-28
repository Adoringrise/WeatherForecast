using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace APIClient
{
    internal class WeatherForecastApi
    {
        private string uri;

        public WeatherForecastApi(string uri)
        {
            this.uri = uri;            
        }

        public async Task<List<WeatherForecast>> GetWeatherForecastList()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(this.uri);

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = await client.GetFromJsonAsync<List<WeatherForecast>>("WeatherForecast");

            return result;
        }
    }
}
