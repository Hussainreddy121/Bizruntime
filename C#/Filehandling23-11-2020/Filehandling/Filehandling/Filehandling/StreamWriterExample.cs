using System;
using System.Collections.Generic;
using System.IO;

namespace Filehandling
{
    class StreamWriterExample
    {
        public static void streamwriter()
        {
            try
            {
                String filename = @"E:\BizRuntime\23-11-2020\streamwrite.txt";
                FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
                StreamWriter streamwriter = new StreamWriter(fileStream);
                streamwriter.WriteLine("hello to C#");
                streamwriter.WriteLine("hello to java");
                streamwriter.WriteLine("hello to html");
                streamwriter.Close();
                fileStream.Close();

            }
            catch(IOException e)
            {
                Console.WriteLine("exception occured " + e.Message);
            }
        }
    }
}
