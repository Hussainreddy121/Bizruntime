using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class SorteddDictionaryprgm
    {
        public static void sortedDictionary()
        {
            SortedDictionary<int, String> keys = new SortedDictionary<int, string>();
            keys.Add(1, "sunday");
            keys.Add(7, "saturday");
            keys.Add(2, "monday");
            keys.Add(6, "friday");
            keys.Add(5, "Thursday");

            foreach (KeyValuePair<int, String> keyValuePair in keys)
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }

            Console.WriteLine(keys.ContainsKey(6));
            Console.WriteLine(keys.ContainsValue("tuesday"));
            Console.WriteLine(keys.Count);
            Console.WriteLine(keys.Remove(1));

            foreach (KeyValuePair<int, String> keyValuePair in keys)
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }

        }
    }
}
