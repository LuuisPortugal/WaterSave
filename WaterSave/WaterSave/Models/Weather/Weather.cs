using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Weather : BaseDataObject
    {
        string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string state;
        public string State
        {
            get { return state; }
            set { SetProperty(ref state, value); }
        }

        string country;
        public string Country
        {
            get { return country; }
            set { SetProperty(ref country, value); }
        }

        List<Date> data;
        public List<Date> Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }
        }
    }
}
