using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void add(int num1, int num2);
    class DelegateWithStatic
    {
        public static void delegatewithstatic(int num1, int num2 )
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
