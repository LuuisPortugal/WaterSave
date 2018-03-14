using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    class Weather : BaseDataObject
    {
        public String Name;
        public String State;
        public String Country;
        public List<Date> Data;
    }
}
