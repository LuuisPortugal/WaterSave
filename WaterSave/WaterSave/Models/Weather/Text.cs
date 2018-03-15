using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSave.Models.Weather
{
    public class Text : BaseDataObject
    {
        string pt;
        public string Pt
        {
            get { return pt; }
            set { SetProperty(ref pt, value); }
        }

        string en;
        public string En
        {
            get { return en; }
            set { SetProperty(ref en, value); }
        }

        string es;
        public string Es
        {
            get { return es; }
            set { SetProperty(ref es, value); }
        }

        Phrase phrase;
        public Phrase Phrase
        {
            get { return phrase; }
            set { SetProperty(ref phrase, value); }
        }    
    }
}
