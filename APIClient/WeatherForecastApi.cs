﻿using System;
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
        const string obsoleteInfo = "use Get method instead";
        const string WeatherForecastEndpointName = "WeatherForecast";
        public const string localImpactEndpointName = "localImpact";

        public WeatherForecastApi(string uri)
        {
            this.uri = uri;
        }


        public async Task<T> Get<T>(string endpoint)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(this.uri);

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = await client.GetFromJsonAsync<T>(endpoint);

            return result;
        }

        [Obsolete(obsoleteInfo)]
        public async Task<List<WeatherForecast>> GetWeatherForecastList()
        {
            var result = await this.Get<List<WeatherForecast>>(WeatherForecastEndpointName);

            return result;
        }

        [Obsolete(obsoleteInfo)]
        public async Task<List<LocalImpact>> GetLocalImpactList()
        {
            var result = await this.Get<List<LocalImpact>>(localImpactEndpointName);

            return result;
        }
    }
}