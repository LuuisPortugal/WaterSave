using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Date : BaseDataObject
    {
        string dateBr = string.Empty;
        public string DateBr
        {
            get { return dateBr; }
            set { SetProperty(ref dateBr, value); }
        }

        Humidity humidity;
        public Humidity Humidity
        {
            get { return humidity; }
            set { SetProperty(ref humidity, value); }
        }

        Rain rain;
        public Rain Rain
        {
            get { return rain; }
            set { SetProperty(ref rain, value); }
        }

        Wind wind;
        public Wind Wind
        {
            get { return wind; }
            set { SetProperty(ref wind, value); }
        }

        Uv uv;
        public Uv Uv
        {
            get { return uv; }
            set { SetProperty(ref uv, value); }
        }

        ThermalSensation thermalSensation;
        public ThermalSensation ThermalSensation
        {
            get { return thermalSensation; }
            set { SetProperty(ref thermalSensation, value); }
        }
        
        TextIcon textIcon;
        public TextIcon TextIcon
        {
            get { return textIcon; }
            set { SetProperty(ref textIcon, value); }
        }
        
        Temperature temperature;
        public Temperature Temperature
        {
            get { return temperature; }
            set { SetProperty(ref temperature, value); }
        }
    }
}
