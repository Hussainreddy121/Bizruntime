using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class LinqFunctions
    {
        public static void linqfunctions()
        {
            int [] values = {12, 45, 67, 5, 56, 2, 4};

            //Max value
            Console.WriteLine(values.Max());

            //Min value
            Console.WriteLine(values.Min());

            //sum value
            Console.WriteLine(values.Sum());

            //count value
            Console.WriteLine(values.Count());

            int result = values.Aggregate((a, b) => a + b);
            Console.WriteLine(result);


        }
    }
}
