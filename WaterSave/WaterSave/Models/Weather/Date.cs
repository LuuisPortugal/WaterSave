using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    class Date : BaseDataObject
    {
        public String Date;
        public String DateBr;
        public Humidity Humidity;
        public Rain Rain;
        public Wind Wind;
        public Uv Uv;
        public ThermalSensation ThermalSensation;
        public TextIcon TextIcon;
        public Temperature Temperature;
    }
}
