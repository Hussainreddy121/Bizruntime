using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DoWhileEx
    {
        public static void dowhilemethod()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
                i++;
            } while (i <= 10);
        }
    }
}
