using System;
using System.Collections.Generic;
using System.Threading;

namespace Threads
{
    class Synchronization
    {
        public void Thread1()
        {
            lock(this)
            {
                Thread t = Thread.CurrentThread;
                for(int i = 1; i<=10; i++)
                {
                    Console.WriteLine(t.Name + " " + i);   
                }
            }
        }
    }
}
