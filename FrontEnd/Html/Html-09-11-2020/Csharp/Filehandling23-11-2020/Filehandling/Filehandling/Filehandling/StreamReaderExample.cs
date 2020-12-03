using System;
using System.Collections.Generic;
using System.IO;

namespace Filehandling
{
    class StreamReaderExample
    {
        public static void streamreader()
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"E:\BizRuntime\23-11-2020\streamwrite.txt");
                String line;
                while((line =streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("exception occured " + e.Message);
            }
        }
    }
}
