using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonLoginov08
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = JObject.Parse(new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(@"https://api.telegram.org/bot1001321317:AAFL2MLgX7bdyxNNmrKEVMZ-Hb3HLUk6GOQ/getupdates"));
            Console.WriteLine(json);

            try
            {
                foreach (dynamic item in json)
                {
                    Console.WriteLine(item.result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            dynamic d = new ExpandoObject();
            d.result = new int[] { 1, 2, 3, 4 };
            d.ok = true;

            var r = JsonConvert.SerializeObject(d);
            Console.WriteLine(r);
        }
    }
}
