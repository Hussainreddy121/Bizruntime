using System;
using System.Collections.Generic;
using System.IO;

namespace Filehandling
{
    class FileExample
    {
         public static void filemethod()
        {
            String filepath = @"E:\BizRuntime\23-11-2020\file.txt";
            if(!File.Exists(filepath))
            {
                 using(StreamWriter stream = File.CreateText(filepath))
                {
                    stream.WriteLine("hello");
                    stream.WriteLine("bangalore");
                    stream.WriteLine("csharp");
                    stream.WriteLine("java");
                }
            }
        }
    }
}
