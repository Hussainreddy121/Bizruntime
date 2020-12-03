using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class HashsetProgram
    {
        public static void hashset()
        {
            HashSet<int> values = new HashSet<int>();
            values.Add(11);
            values.Add(12);
            values.Add(34);
            values.Add(1);
            values.Add(11);
            values.Add(99);


            foreach(int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
