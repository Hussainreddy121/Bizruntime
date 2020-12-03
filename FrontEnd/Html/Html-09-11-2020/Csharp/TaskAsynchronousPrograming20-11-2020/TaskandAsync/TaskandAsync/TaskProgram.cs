using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskandAsync
{
    class TaskProgram
    {
        public static void taskoperation()
        {
            Task t = Task.Run(() =>
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine("Hi " + i);
                        }
                       
                    });
            Console.WriteLine(t);
        }
    }
}
