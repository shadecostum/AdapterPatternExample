using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class AdapterClass:DataAnalaticsTool
    {
        XmlDataClass XmlDataClass;
        public AdapterClass(XmlDataClass xmlData)
        {
            XmlDataClass = xmlData;
        }

        public override void getDataAnalatics()
        {
            Console.WriteLine("Converted Xml data  "+XmlDataClass.XmlDataa);
            Console.WriteLine("showing  Json data");
        }
    }
}
