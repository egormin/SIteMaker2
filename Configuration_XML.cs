using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Site_Maker_2
{
    class Configuration_XML
    {       
            public void meth_Configuration_XML(string ENVpath, string STAMPSpath, string KPDpath)
            {
                //string xmlPath = path;


                XDocument doc = new XDocument(new XElement("Конфигурация",
                 new XElement("Конверты", ENVpath),
                 new XElement("Марки", STAMPSpath),
                 new XElement("КПД", KPDpath)));              


                //сохраняем наш документ
                doc.Save("configuration.xml");
            }
    }
}
