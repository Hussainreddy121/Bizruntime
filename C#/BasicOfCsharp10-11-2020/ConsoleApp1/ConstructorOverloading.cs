using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConstructorOverloading
    {
        public ConstructorOverloading()
        {
            Console.WriteLine("no argument int type ");
        }
        ConstructorOverloading(int i)
        {
            Console.WriteLine("sinle argument int type " + i);
        }
        ConstructorOverloading(string name)
        {
            Console.WriteLine("sinle argument string type " + name);
        }
        ConstructorOverloading(float value)
        {
            Console.WriteLine("sinle argument float type " + value);
        }
        ConstructorOverloading(string name, int j, char c)
        {
            Console.WriteLine("three arguments  type " + name + "," + j + "," + c);
        }
        public void constructoroverload()
        {
            ConstructorOverloading co1 = new ConstructorOverloading(10);
            ConstructorOverloading co2 = new ConstructorOverloading("ravi");
            ConstructorOverloading co3 = new ConstructorOverloading(0.4f);
            ConstructorOverloading co4 = new ConstructorOverloading("hello", 34, 'd');

        }
    }
}
