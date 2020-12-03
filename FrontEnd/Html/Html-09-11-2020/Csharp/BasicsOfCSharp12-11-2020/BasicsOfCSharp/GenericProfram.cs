using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class GenericProfram<A>
    {
        
        GenericProfram()
        {

        }
        public GenericProfram(A msg)
        {
            Console.WriteLine(msg);
        }
        public void genericMethod()
        {
            GenericProfram<int> gp = new GenericProfram<int>(10);
            GenericProfram<string> gp1 = new GenericProfram<string>("generic");
            GenericProfram<bool> gp2 = new GenericProfram<bool>(false);

        }
    }
}
