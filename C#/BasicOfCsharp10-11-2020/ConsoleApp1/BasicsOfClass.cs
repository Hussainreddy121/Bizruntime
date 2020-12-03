using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BasicsOfClass
    {
        int id;
        String name;
        BasicsOfClass(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public  BasicsOfClass()
        {

        }

            public  void details()
        {
            BasicsOfClass b1 = new BasicsOfClass(1, "hari");
            BasicsOfClass b2 = new BasicsOfClass(2, "ravi");
            Console.WriteLine("id " + b1.id + "name " + b1.name);
            Console.WriteLine("id " + b2.id + "name " + b2.name);


        }
    }
}
