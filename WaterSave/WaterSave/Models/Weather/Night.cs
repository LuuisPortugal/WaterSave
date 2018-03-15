using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Night : BaseDataObject
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
    }
}
