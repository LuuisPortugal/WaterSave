using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Phrase : BaseDataObject
    {
        string reduced;
        public string Reduced
        {
            get { return reduced; }
            set { SetProperty(ref reduced, value); }
        }

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
    }
}
