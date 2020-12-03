using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
    class MultiThreading
    {
        public static void mutithreadone()
        {
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine("thread one " + i);
            }
        }

        public void mutithreadtwo()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("thread two " + i);
            }
        }
    }
}
