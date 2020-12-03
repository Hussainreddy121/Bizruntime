using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
    public abstract class Abstraction
    {
        public abstract void vehicle();
        public abstract void vehicleType();
    }

    public class VehicalDetails : Abstraction
    {
        public override void vehicle()
        {
            Console.WriteLine("Car");
        }

        public override void vehicleType()
        {
            Console.WriteLine("petrol");
        }
    }
}
