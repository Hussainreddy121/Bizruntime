using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseEx
    {
        public static void switchcaseex()
        {
            int num = 40;
            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }
        }
    }
}
