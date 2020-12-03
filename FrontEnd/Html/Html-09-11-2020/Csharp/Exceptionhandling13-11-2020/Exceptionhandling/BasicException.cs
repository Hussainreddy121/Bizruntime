using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class BasicException
    {
        public static void exceptionmethod()
        {
            int a = 10, b = 0;
            try
            {
                int c = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
