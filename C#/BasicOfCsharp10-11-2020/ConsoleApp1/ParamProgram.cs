using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParamProgram
    {
        public void show(ParamProgram paramProgram)
        {
            paramProgram.print(2,3,6,8); 
        }

        void print(params int[] val)
        {
            foreach(int i in val)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
