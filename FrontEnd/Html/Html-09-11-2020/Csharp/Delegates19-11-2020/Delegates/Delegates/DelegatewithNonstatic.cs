using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void customer (string name);
    class DelegatewithNonstatic
    {
        public void delegatewithNonstatic(string name)
        {
            Console.WriteLine(name);
        }
    }
}
