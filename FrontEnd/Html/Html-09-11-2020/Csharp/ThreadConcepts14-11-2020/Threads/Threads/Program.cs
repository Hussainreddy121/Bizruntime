using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            MainThread.mainthread();

            MultiThreading mt = new MultiThreading();
            Thread t1 = new Thread(new ThreadStart(MultiThreading.mutithreadone));
            Thread t2 = new Thread(new ThreadStart(mt.mutithreadtwo));
            t1.Start();
            t2.Start();

            ThreadMethods tm = new ThreadMethods();
            Thread td = new Thread(new ThreadStart(tm.thread1));
            Thread td1 = new Thread(new ThreadStart(tm.thread1));

            td.Start();
            td1.Start();
            td1.Join();

            Synchronization synchronization = new Synchronization();
            Thread ts = new Thread(new ThreadStart(synchronization.Thread1));
            Thread ts1 = new Thread(new ThreadStart(synchronization.Thread1));
            Thread ts2 = new Thread(new ThreadStart(synchronization.Thread1));

            ts.Name = "TS ";
            ts1.Name = "TS1 ";
            ts2.Name = "Ts2 ";

            ts.Start();
            ts1.Start();
            ts2.Start();
        }
    }
}
