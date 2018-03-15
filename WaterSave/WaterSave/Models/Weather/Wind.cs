using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Wind : BaseDataObject
    {
        int velocityMin;
        public int VelocityMin
        {
            get { return velocityMin; }
            set { SetProperty(ref velocityMin, value); }
        }

        int velocityMax;
        public int VelocityMax
        {
            get { return velocityMax; }
            set { SetProperty(ref velocityMax, value); }
        }

        int velocityAvg;
        public int VelocityAvg
        {
            get { return velocityAvg; }
            set { SetProperty(ref velocityAvg, value); }
        }

        int gustMax;
        public int GustMax
        {
            get { return gustMax; }
            set { SetProperty(ref gustMax, value); }
        }

        int directionDegrees;
        public int DirectionDegrees
        {
            get { return directionDegrees; }
            set { SetProperty(ref directionDegrees, value); }
        }

        string direction;
        public string Direction
        {
            get { return direction; }
            set { SetProperty(ref direction, value); }
        }
    }
}
