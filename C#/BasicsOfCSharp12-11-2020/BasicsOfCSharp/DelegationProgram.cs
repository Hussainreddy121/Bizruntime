using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    public delegate void adddelegate(int num); 
    class DelegationProgram
    {
        public void add(int num)
        {
            Console.WriteLine(num);
        }
    }
}
