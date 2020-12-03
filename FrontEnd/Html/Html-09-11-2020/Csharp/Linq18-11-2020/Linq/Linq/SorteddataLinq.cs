using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class SorteddataLinq
    {
        public static void sortingdatausingLinq()
        {
            String[] names = { "red", "black", "blue", "green", "orange" };

            /* var sortednames = from name in names
                               orderby name.Length
                               select name;*/

            var sortednames = names.OrderBy(n => n.Length);
            foreach (string s in sortednames)
            {
                Console.WriteLine(s);
            }
        }
    }
}
