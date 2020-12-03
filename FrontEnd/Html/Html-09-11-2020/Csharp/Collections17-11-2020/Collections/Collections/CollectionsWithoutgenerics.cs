using System;
using System.Collections;
using System.Text;

namespace Collections
{
    class CollectionsWithoutgenerics
    {
        public static void withoutgenerics()
        {
             List arrayList = new ArrayList();
            arrayList.Add("java");
            arrayList.Add(2);
            arrayList.Add(0.8f);
            arrayList.Add(true);
            arrayList.Add('h');

            for(int index = 0; index <arrayList.Count; index++)
            {
                Console.WriteLine(arrayList[index]);

            }
        }
    }
}
