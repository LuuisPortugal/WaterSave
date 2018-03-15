using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Icon : BaseDataObject
    {
        string dawn;
        public string Dawn
        {
            get { return dawn; }
            set { SetProperty(ref dawn, value); }
        }

        string morning;
        public string Morning
        {
            get { return morning; }
            set { SetProperty(ref morning, value); }
        }

        string afternoon;
        public string Afternoon
        {
            get { return afternoon; }
            set { SetProperty(ref afternoon, value); }
        }

        string night;
        public string Night
        {
            get { return night; }
            set { SetProperty(ref night, value); }
        }

        string day;
        public string Day
        {
            get { return day; }
            set { SetProperty(ref day, value); }
        }
    }
}
