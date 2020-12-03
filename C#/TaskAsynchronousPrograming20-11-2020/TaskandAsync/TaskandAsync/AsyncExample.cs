using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskandAsync
{
   public class AsyncExample
    {
        public static void asynckeyword()
        {
            AyncsKeyword.Dowork();
            Console.WriteLine("fnsf");
           
        }

       
    }
     class AyncsKeyword
    {
        public static async Task Dowork()
        {
            await Task.Run(() => {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine( "hello" + i);
                }
            });
        }
    }
}
