using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class XmlDataClass
    {
        public string XmlDataa { get; set; }

        public XmlDataClass(string xmldata) 
        {
            XmlDataa = xmldata;
        }

      // public string getXmlData() { return XmlDataa; }
    }
}
