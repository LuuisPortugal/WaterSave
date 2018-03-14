using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    class Temperature : BaseDataObject
    {
        public int Min;
        public int Max;
        public Morning Morning;
        public Afternoon Afternoon;
        public Night Night;
    }
}
