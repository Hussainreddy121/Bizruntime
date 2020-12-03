using System;
using System.Collections.Generic;
using System.IO;

namespace Filehandling
{
    class BinaryWriterExample
    {
        public static void binarywriter()
        {
            try
            {
                
                using (BinaryWriter writer = new BinaryWriter(File.Open("E:\\BizRuntime\\23-11-2020\\binaryfile.dat", FileMode.Create)))
                {

                    writer.Write(12.5);
                    writer.Write("this is string data");
                    writer.Write(true);
                    writer.Write(78);

                }
            }

            catch(IOException e)
            {
                Console.WriteLine("exception occured " + e);
            }
        }


        public static void binaryreader()
        {


            using (BinaryReader reader = new BinaryReader(File.Open("E:\\BizRuntime\\23-11-2020\\binaryfile.dat", FileMode.Open)))
            {

                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                Console.WriteLine("int Value : " + reader.ReadInt32());

            }
          

           
        }
    }
}
