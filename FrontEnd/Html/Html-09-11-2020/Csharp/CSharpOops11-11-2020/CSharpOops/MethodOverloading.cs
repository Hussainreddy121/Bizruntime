using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
    class MethodOverloading
    {
        public void add(int i, int j)
        {
            i = i + j;
            Console.WriteLine("method overload " + i);
        }

        public void add(float i, float j)
        {
            i = i + j;
            Console.WriteLine("method overload " + i);
        }
    }
}

