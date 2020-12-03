using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CallByRefernce
    {
       

        public void callByrefshow(int value, CallByRefernce callByRefernce)
        {
            Console.WriteLine("before calling ref " + value);            
            callByRefernce.print(ref value);
            Console.WriteLine("after calling ref " + value);
            
        }

        void print(ref int value)
        {
            value += value;
            Console.WriteLine("while ref " + value);
        }
    }
}
