using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Json
{
    class Jsonparse
    {
        public static void jsonObjectMethod()
        {
            string json = @"{
                      car: 'BMW',
                      CarNo: ['2244', '4466']
                     }";
            JObject obj = JObject.Parse(json);
             Console.WriteLine(obj);


            string json1 = @"['Small', 'Medium', 'Large']";

            JArray array = JArray.Parse(json1);
            Console.WriteLine(array);
        }
    }
}
