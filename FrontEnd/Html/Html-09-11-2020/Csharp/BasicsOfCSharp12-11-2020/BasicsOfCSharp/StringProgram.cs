using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class StringProgram
    {
        public void stringBasic()
        {
            String s1 = "hello";
            string s2 = new string("bangalore");
            Console.WriteLine("Concat two Strings " + String.Concat(s1, s2));
            Console.WriteLine("Compare two Strings " + string.Compare(s1, s2));
            s1 = "   hello";
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s1.TrimStart());
            Console.WriteLine("replacing a string " + s2.Replace('b', 'B'));


        }

        public  void stringmethods()
        {

            int a = 123;
            string s1 = a.ToString();
            Console.WriteLine(s1);

            string s2 = "helllo to bangalore";
            string s3 = s2.ToUpper();
            Console.WriteLine(s3);
            char[] ch = s2.ToCharArray();
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            //substring
            string s4 = s2.Substring(2);
            Console.WriteLine(s4);
        }
    }
}
