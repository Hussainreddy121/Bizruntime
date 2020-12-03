using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class DictionaryProgram
    {
        public static void dictionarymethod()
        {
            Dictionary<int, String> keyvalue = new Dictionary<int, string>();
            keyvalue.Add(1, "sunday");
            keyvalue.Add(7, "saturday");
            keyvalue.Add(2, "monday");
            keyvalue.Add(6, "friday");
            keyvalue.Add(5, "Thursday");

            foreach(KeyValuePair<int, String> keyValuePair in keyvalue)
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }

            // only keys
            Dictionary<int, string>.KeyCollection onlykeys = keyvalue.Keys;

            foreach(int key in onlykeys)
             {
                Console.WriteLine("keys = {0}", key);
            }

            
        }
    }
}
