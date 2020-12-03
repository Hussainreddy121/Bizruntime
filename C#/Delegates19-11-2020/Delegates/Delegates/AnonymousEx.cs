using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void Print(int value);

    class AnonymousEx
    {
        public static void anonymousmethod()
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}
