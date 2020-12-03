using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Filehandling
{
    class Directoryexample
    {
        public static void direcotymethod()
        {
            string root = @"E:\";
              
            var dirs = from dir in
                Directory.EnumerateDirectories(root)
                       select dir;
            Console.WriteLine("Subdirectories: {0}", dirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            
        }
    }
}
