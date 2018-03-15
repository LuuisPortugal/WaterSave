using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Uv : BaseDataObject
    {
        int max;
        public int Max
        {
            get { return max; }
            set { SetProperty(ref max, value); }
        }
    }
}
