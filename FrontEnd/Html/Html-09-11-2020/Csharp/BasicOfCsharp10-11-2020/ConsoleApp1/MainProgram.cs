using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            int originalvalue = 10;
            CallByValue.show(originalvalue);

            CallByRefernce callByRefernce = new CallByRefernce();
            callByRefernce.callByrefshow(originalvalue, callByRefernce);

            int[] arr = { 10, 20, 5, 22, 66, 47, 6 };
            Arrays array = new Arrays();
            array.traverse(arr);
            array.reverse(arr);
            array.sorting(arr, array);

            BasicsOfClass basics = new BasicsOfClass();
            basics.details();

            ConstructorOverloading co = new ConstructorOverloading();
            co.constructoroverload();

            ParamProgram paramProgram = new ParamProgram();
            paramProgram.show(paramProgram);               

            SwitchCaseEx.switchcaseex();

            DoWhileEx.dowhilemethod();

        }
    }
}
