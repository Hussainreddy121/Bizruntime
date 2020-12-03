using System;
using System.Threading;

namespace Threads
{
    class ThreadMethods
    {
        public void thread1()
        {
              Thread t1 = Thread.CurrentThread;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(t1.Name + i);
                }
            
        }
    }
}
