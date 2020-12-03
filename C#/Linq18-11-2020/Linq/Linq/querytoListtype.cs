using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class querytoListtype
    {
        public static void querytolist()
        {
            List<string> list = new List<string>() { "bangalore", "hyderbad", "mumbai", "chennai", "delhi" };

           /* IEnumerable<string> values = from value in list
                                         where value == "bangalore"
                                         select value;*/
           

            var values = list.Where(v => v.Contains("bangalore"));

            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
        }
    }
}
