using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class ConversionOperators
    {
       public static void conversionoperators()
        {
            int[] aray = { 1, 3, 6, 7, 5 };

            //To List()
            List<int> list = aray.ToList();

            // To Array
            List<int> list1 = new List<int>() { 10, 34, 56 };
            int[] array = list1.ToArray();
        }
    }
}
