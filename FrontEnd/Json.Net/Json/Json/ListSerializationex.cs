using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Json
{
    class ListSerializationex
    {
        public static void listmethod()
        {
            List<string> list = new List<string>() { "ravi", "mahesh", "rahul", "pathan" };

            String result = JsonConvert.SerializeObject(list, Formatting.Indented);
            Console.WriteLine(result);

           
        }
    }
}
