using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class SortedListPrgm
    {
        public static void sortedlistmethod()
        {
            SortedList<String, String> list = new SortedList<string, string>();
            list.Add("1", "ravi");
            list.Add("0", "mahesh");
            list.Add("23", "madhu");
            list.Add("2", "venky");

            foreach(KeyValuePair<string, string> keyValue in list)
            {
                Console.WriteLine("key ={0}, value ={1}", keyValue.Key, keyValue.Value);
            }

            // only values
            IList<string> values = list.Values;
            foreach(String s in values)
            {
                Console.WriteLine("value = {0}", s);
            }
        }
    }
}
