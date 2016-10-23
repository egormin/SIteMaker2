using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Site_Maker_2
{
    class LoadDataFromConfig
    {
        public string meth_LoadDataFromConfig()
        {
            string pathes = "";
            string ENVpath = "";
            string STAMPpath = "";
            string KPDpath = "";

            string path = AppDomain.CurrentDomain.BaseDirectory + "configuration.xml";
            XDocument xdoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "configuration.xml");

            foreach (XElement el in xdoc.Root.Elements())
            {
    switch (Convert.ToString(el.Name))
                {
                    case "Конверты":
                    {
                        ENVpath= el.Value + "#";
                        break;
                    }

                    case "Марки":
                    {
                        STAMPpath = el.Value + "#";
                        break;
                    }

                    case "КПД":
                    {
                        KPDpath = el.Value;
                        break;
                    }
                }           

              }
            return pathes = ENVpath + STAMPpath + KPDpath;
        }

    }
}

