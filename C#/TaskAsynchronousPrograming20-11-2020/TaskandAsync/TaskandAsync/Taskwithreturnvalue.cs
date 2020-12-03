using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskandAsync
{
    class Taskwithreturnvalue
    {
        public static void taskOpertion()
        {
            Task<int> task = new Task<int>(() =>
              {
                  int[] array = { 2, 5, 7, 67, 54, 6 };
                  int sum = 0;
                  for (int i = 0; i < array.Length; i++)
                  {
                      sum += array[i];
                  }
                  return sum;
              });
            task.Start();
            int result = Convert.ToInt32(task.Result);
            Console.WriteLine("sum of array elements are " + result);
        }
    }
}
