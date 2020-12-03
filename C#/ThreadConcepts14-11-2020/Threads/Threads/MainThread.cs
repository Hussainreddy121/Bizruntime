using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class MainThread
    {
        public static void mainthread()
        {
            Thread t1 = Thread.CurrentThread;
             t1.Name = "Main thread";
            Console.WriteLine("thread name is " + t1.Name);
        }
    }
}
