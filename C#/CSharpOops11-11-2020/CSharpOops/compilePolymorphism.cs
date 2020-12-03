using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
   public  class compilePolymorphism
    {
         public static void comiplepolymrphsim()
        {
            Animal a = new Dog();
            a.eat();
        }
    }

    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }

    }
}
