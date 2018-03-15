using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Rain : BaseDataObject
    {
        int probability;
        public int Probability
        {
            get { return probability; }
            set { SetProperty(ref probability, value); }
        }

        int precipitation;
        public int Precipitation
        {
            get { return precipitation; }
            set { SetProperty(ref precipitation, value); }
        }
    }
}
