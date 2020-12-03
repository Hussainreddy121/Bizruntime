using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class Trycatchfinallyblocks
    {
        public static void blocksmethod()
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {
                int value = arr[10];
            } 
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Finally block 
           
            finally
            {
                Console.WriteLine("finally block");
            }

        }
    }
}
