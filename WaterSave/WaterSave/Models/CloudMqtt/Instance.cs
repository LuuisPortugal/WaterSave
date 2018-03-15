using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.CloudMqtt
{
    public class Instance : BaseDataObject
    {
        string plan;
        public string Plan
        {
            get { return plan; }
            set { SetProperty(ref plan, value); }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string region;
        public string Region
        {
            get { return region; }
            set { SetProperty(ref region, value); }
        }

        string url;
        public string Url
        {
            get { return url; }
            set { SetProperty(ref url, value);  }
        }
    }
}
