using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Temperature : BaseDataObject
    {
        int min;
        public int Min
        {
            get { return min; }
            set { SetProperty(ref min, value); }
        }

        int max;
        public int Max
        {
            get { return max; }
            set { SetProperty(ref max, value); }
        }

        Morning morning;
        public Morning Morning
        {
            get { return morning; }
            set { SetProperty(ref morning, value); }
        }

        Afternoon afternoon;
        public Afternoon Afternoon
        {
            get { return afternoon; }
            set { SetProperty(ref afternoon, value); }
        }

        Night night;
        public Night Night
        {
            get { return night; }
            set { SetProperty(ref night, value); }
        }
    }
}
