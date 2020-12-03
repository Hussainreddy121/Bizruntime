using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class ListProgram
    {
        public void listmethod()
        {
            List<string> list = new List<string>();
            list.Add("Csharp");
            list.Add("java");
            list.Add("python");
            list.Add("html");
            list.Add("css");
            list.Add("Angular");

            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
        }


    }
}
