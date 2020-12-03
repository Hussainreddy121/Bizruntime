using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrays
    {
        public void traverse(int[] arry)
        {
            Console.WriteLine("Array elements ");
            for(int i = 0; i<arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
        }

        public void sorting(int[] arry, Arrays array)
        {
            Console.WriteLine("sorted  ");
            Array.Sort(arry);
            array.traverse(arry);
        }

        public void reverse(int[] arry)
        {
            Console.WriteLine("reversed elements ");
            for (int i = arry.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(arry[i]);
            }
        }


    }
}
