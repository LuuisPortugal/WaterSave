using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class TextIcon : BaseDataObject
    {
        Icon icon;
        public Icon Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }

        Text text;
        public Text Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
