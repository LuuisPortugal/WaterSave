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
    class WeatherDataStore : IDataStore<Date>
    {
        bool isInitialized;

        bool IsSuccessStatusCode;
        Weather Weather;
        WeatherErro WeatherErro;

        public async Task<bool> AddItemAsync(Date item)
        {
            await InitializeAsync();

            Weather.Data.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Date item)
        {
            await InitializeAsync();

            var _item = Weather.Data.FirstOrDefault(s => s.Id == item.Id);
            Weather.Data.Remove(_item);
            Weather.Data.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Date item)
        {
            await InitializeAsync();

            var _item = Weather.Data.FirstOrDefault(s => s.Id == item.Id);
            Weather.Data.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Date> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(Weather.Data.FirstOrDefault(s => s.Id == id));
        }

        public async Task<Date> GetItemAsyncByDate(string date)
        {
            await InitializeAsync();

            return await Task.FromResult(Weather.Data.FirstOrDefault(s => s.DateBr == date));
        }

        public async Task<IEnumerable<Date>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeAsync();

            return await Task.FromResult(Weather.Data);
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }


        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

        public async Task InitializeAsync()
        {
            if (isInitialized)
                return;

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            var url = string.Format(
                App.Current.Resources["WS_CT_UrlForecast15"] as String,
                App.Current.Resources["WS_CT_Key"] as String,
                App.Current.Resources["WS_CT_BelemID"] as String
            );

            var uri = new Uri(url);
            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            if (IsSuccessStatusCode = response.IsSuccessStatusCode)
            {
                Weather = JsonConvert.DeserializeObject<Weather>(content);
            }
            else
            {
                WeatherErro = JsonConvert.DeserializeObject<WeatherErro>(content);
            }

            isInitialized = true;
        }
    }
}