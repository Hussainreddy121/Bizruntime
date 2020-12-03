using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskandAsync
{
    class AsyncAndawait
    {
        public static async void callingmethod()
        {
            Console.WriteLine("calling method begins");
            Task<int> t = Method1();
            Method2();
            int value = await t;
            Method3(value);
        }

        static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("method1 " + i);
                    count += i;
                }
            });

            return count;

        }

         static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }


    }
}
