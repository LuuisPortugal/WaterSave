using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class WeatherErro : BaseDataObject
    {
        int statusCode;
        public int StatusCode
        {
            get { return statusCode; }
            set { SetProperty(ref statusCode, value); }
        }

        string detail;
        public string Detail
        {
            get { return detail; }
            set { SetProperty(ref detail, value); }
        }
    }
}
