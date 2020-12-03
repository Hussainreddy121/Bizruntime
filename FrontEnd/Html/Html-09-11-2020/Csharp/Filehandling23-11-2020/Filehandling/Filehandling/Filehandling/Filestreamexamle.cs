using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Filehandling
{
    class Filestreamexamle
    {
        public static void filestreammethod()
        {
            FileStream fstream = new FileStream(@"E:\BizRuntime\23-11-2020\filestream.txt", FileMode.OpenOrCreate);
            var text = "hello to bizruntime and bangalore";
            byte[] array = Encoding.UTF8.GetBytes(text);
            fstream.Write(array, 0, text.Length);
            fstream.Close();


            //read operation
            FileStream stream = new FileStream(@"E:\BizRuntime\23-11-2020\filestream.txt", FileMode.Open);
            byte[] barray = new byte[1024];
            UTF8Encoding encoding = new UTF8Encoding(true);
            while(stream.Read(barray, 0, barray.Length) > 0)
            {
                Console.WriteLine(encoding.GetString(barray));
            }

        }
    }
}
