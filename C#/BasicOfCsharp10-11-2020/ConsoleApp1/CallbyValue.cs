using System;

namespace ConsoleApp1
{
    class CallByValue
    {
       

         void print(int value)
        {
            int value1 = value + 9;
            Console.WriteLine(value1);
        }

        public  static void show(int value)
        {
            Console.WriteLine(value + " before calling a function");
            CallByValue callByValue = new CallByValue();
            callByValue.print(value);
            Console.WriteLine(value + " after calling a function");
        }
    }
}
