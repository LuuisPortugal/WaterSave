using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using Xamarin.Forms;

using WaterSave.Models.CloudMqtt;
using WaterSave.Helpers;
using System.Diagnostics;
using System.Net.Http.Headers;

[assembly: Dependency(typeof(WaterSave.Services.CloudMqttDataStore))]
namespace WaterSave.Services
{
    class CloudMqttDataStore : IDataStore<Instance>
    {
        bool isInitialized;
        List<Instance> Instance;
        HttpClient client;
        ResourceDictionary resources;

        public CloudMqttDataStore()
        {
            client = new HttpClient();
            resources = App.Current.Resources;

            var authUserData = String.Format("{0}:{1}", resources["WS_CM_User"] as string, resources["WS_CM_Password"] as string);
            var authHeaderVal = Convert.ToBase64String(Encoding.UTF8.GetBytes(authUserData));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderVal);
        }

        public async Task<bool> AddItemAsync(Instance item)
        {
            await InitializeAsync();

            Instance.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Instance item)
        {
            await InitializeAsync();

            var _item = Instance.FirstOrDefault(s => s.Id == item.Id);
            Instance.Remove(_item);
            Instance.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Instance item)
        {
            await InitializeAsync();

            var _item = Instance.FirstOrDefault(s => s.Id == item.Id);
            Instance.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Instance> GetItemAsync(string id)
        {
            await InitializeAsync();

            Instance instance = Instance.FirstOrDefault(s => s.Id == id);

            var url = String.Format(resources["WS_CM_UrlInstance"] as string, id);
            var uri = new Uri(url);

            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            instance = JsonConvert.DeserializeObject<Instance>(content);

            await UpdateItemAsync(instance);
            return await Task.FromResult(instance);
        }

        public async Task<IEnumerable<Instance>> GetItemsAsync(bool forceRefresh = false)
        {
            isInitialized = isInitialized && !forceRefresh;

            await InitializeAsync();

            return await Task.FromResult(Instance);
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

            var uri = new Uri(resources["WS_CM_UrlListInstance"] as string);
            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Instance = JsonConvert.DeserializeObject<List<Instance>>(content);

            isInitialized = true;
        }
    }
}