using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class StackProgram
    {
        public static void stackmethod()
        {
            Stack<String> names = new Stack<string>();
            names.Push("ravi");
            names.Push("mahesh");
            names.Push("suresh");
            names.Push("madhu");
            names.Push("venky");

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(names.Pop());
            Console.WriteLine(names.Peek());
        }
    }
}
