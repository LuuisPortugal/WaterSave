using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WaterSave.Models.Weather
{
    class WeatherResult : BaseDataObject
    {
        bool IsSuccessStatusCode;
        Weather Weather;
        String Erro;

        public WeatherResult(bool isSuccessStatusCode, string content)
        {
            IsSuccessStatusCode = isSuccessStatusCode;
            if (isSuccessStatusCode)
            {
                Weather weather = JsonConvert.DeserializeObject<Weather>(content);
                Weather = weather;
                Erro = null;
            }
            else
            {
                WeatherErro WeatherErro = JsonConvert.DeserializeObject<WeatherErro>(content);                
                Erro = WeatherErro.Detail;
                Weather = null;
            }
        }
    }
}
