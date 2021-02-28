using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.NBitcoin;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string api = "****";

            string searchword = Console.ReadLine();
            string SWurl = HttpUtility.UrlEncode(searchword);
            String apiurl = api;
            WebRequest request = WebRequest.Create(apiurl);
            WebResponse Res = request.GetResponse();
            StreamReader reader = new StreamReader(Res.GetResponseStream(), new UTF8Encoding(false));
            var obj_from_json = JArray.Parse(reader.ReadToEnd());

            Console.WriteLine(obj_from_json);
            Console.ReadLine();
        }
    }
}
