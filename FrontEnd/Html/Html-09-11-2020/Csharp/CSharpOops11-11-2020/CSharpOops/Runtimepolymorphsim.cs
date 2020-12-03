using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
    class Runtimepolymorphsim
    {
        public void runtimepolymorphsim()
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    }

    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing shape...");
        }

    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }

    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }

    }
}
