using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class finallyblock
    {
        public static void finallymethod()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {
                Console.WriteLine(arr[7]);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }

        }
    }
}
