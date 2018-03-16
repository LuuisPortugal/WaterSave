using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WaterSave.Models.CloudMqtt
{
    public class Instance : BaseDataObject
    {
        public const string COMPONENT_CAIXA = "Caixa";
        public const string COMPONENT_CISTERNA = "Cisterna";
        public const string COMPONENT_BOMBA = "Bomba";
        public const string COMPONENT_VALVULA = "Valvula";

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

        ImageSource icon;
        public ImageSource Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }

        string value;
        public string Value
        {
            get { return value; }
            set { SetProperty(ref this.value, value); }
        }

        string type;
        public string Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }

        string component;
        public string Component
        {
            get { return component; }
            set { SetProperty(ref component, value); }
        }

        string description;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
    }
}
