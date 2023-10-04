using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class ClientClass
    {
       public void ProcessData(DataAnalaticsTool tool)
        {
            tool.getDataAnalatics();
        }
    }
}
