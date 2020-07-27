using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace les02
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new ExpandoObject();
            d.result = new int[] { 1, 2, 3, 4 };
            d.ok = true;

            XElement xElementRoot = new XElement("root");

            XElement xElementResult = new XElement("result");

            foreach (dynamic item in d.result)
            {
                XElement xElementResultItem = new XElement("resultItem", item);

                xElementResult.Add(xElementResultItem);
            }



            XElement xElementOk = new XElement("ok", d.ok = true);

            xElementRoot.Add(xElementResult, xElementOk);
            xElementRoot.Save("qwe.xml");
        }
    }
}
