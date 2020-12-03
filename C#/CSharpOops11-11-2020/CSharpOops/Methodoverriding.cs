using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
    class Methodoverriding
    {
        public String color = "white";
        public virtual void Dog()
        {
            Console.WriteLine("Eating");
        }
    }

    class DerivedClass : Methodoverriding
    {
        public String color = "black";
        public override void Dog()
        {
            Console.WriteLine("sleeping");
            DerivedClass dc = new DerivedClass();
            Console.WriteLine(dc.color);
            Console.WriteLine(base.color);
        }

    }

}
