using System;
using System.Collections;
using System.Text;

namespace Collections
{
    class Hashtableprgm
    {

        public static void hashtablemethod()
        {
            Hashtable openWith = new Hashtable();

            
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            foreach(DictionaryEntry entry in openWith)
            {
                Console.WriteLine("key = {0}, value = {1}", entry.Key, entry.Value);
            }

            
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            ICollection valueColl = openWith.Values;

            
            //  values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }
        }
    }
}
