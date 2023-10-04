using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class DataAnalaticsTool
    {
        string JsonData;
        public DataAnalaticsTool() { }
        public DataAnalaticsTool(string json) 
        {
          JsonData = json;
        }

        public virtual void getDataAnalatics()
        {
            Console.WriteLine("data Contain Json Data" + JsonData);
        }
    }
}
