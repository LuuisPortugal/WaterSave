using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    class Temperature : BaseDataObject
    {
        int Min;
        int Max;
        Morning Morning;
        Afternoon Afternoon;
        Night Night;
    }
}
