using AdapterPattern.Models;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDataClass xmlData=new XmlDataClass("Xml data added");


            // DataAnalaticsTool dataAnalaticsTool = new DataAnalaticsTool();
            //this class expect json data,we dont have any json data to pass


            DataAnalaticsTool dataAnalaticss = new AdapterClass(xmlData);
           

            ClientClass clientClass=new ClientClass();
            clientClass.ProcessData(dataAnalaticss);
            
        }
    }
}