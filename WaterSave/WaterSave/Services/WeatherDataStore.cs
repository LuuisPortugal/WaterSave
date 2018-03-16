using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using Xamarin.Forms;

using WaterSave.Models.Weather;
using WaterSave.Helpers;
using System.Diagnostics;

[assembly: Dependency(typeof(WaterSave.Services.WeatherDataStore))]
namespace WaterSave.Services
{
    class WeatherDataStore : IDataStore<Date>
    {
        bool isInitialized;
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

        public async Task<IEnumerable<Date>> GetItemsAsync(bool forceRefresh = false)
        {
            isInitialized = isInitialized && !forceRefresh;

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
        
            var resources = App.Current.Resources;
            var url = string.Format(resources["WS_CT_UrlForecast15"] as string, resources["WS_CT_Key"] as string, resources["WS_CT_BelemID"] as string);
            var uri = new Uri(url);

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();           

            response.EnsureSuccessStatusCode();
            Weather = JsonConvert.DeserializeObject<Weather>(content);

            isInitialized = true;
        }
    }
}