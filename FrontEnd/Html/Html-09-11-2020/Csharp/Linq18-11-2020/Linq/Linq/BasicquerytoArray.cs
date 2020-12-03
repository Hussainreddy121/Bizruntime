using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class BasicquerytoArray
    {
        public static void querytoArrays()
        {
            String[] array = { "java", "html", "csharp", "css", "angular", "ajax" };

            /*var query = from value in array
                        where value.Contains('a')
                        select value;

            foreach(string n in query)
            {
                Console.WriteLine(n);
            }*/

            var methodquery = array.Where(value => value.Contains('a'));

            foreach (string n in methodquery)
            {
                Console.WriteLine(n);
            }

        }
    }
}
