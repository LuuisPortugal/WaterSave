using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using WaterSave.Models.Weather;

namespace WaterSave.Services
{
    class WeatherDataStore
    {
        private HttpClient client;

        public WeatherDataStore()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<WeatherResult> GetForecast15Async()
        {
            var url = string.Format(
                App.Current.Resources["WS_CT_UrlForecast15"].ToString(),
                App.Current.Resources["WS_CT_Key"].ToString(),
                App.Current.Resources["WS_CT_BelemID"].ToString()
            );

            var uri = new Uri(url);
            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            return new WeatherResult(response.IsSuccessStatusCode, content);
        }
    }
}