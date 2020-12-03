using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class QueueProgram
    {
        public static void queuemethod()
        {
            Queue<String> queue = new Queue<string>();
            queue.Enqueue("BTM");
            queue.Enqueue("slikboard");
            queue.Enqueue("marthalli");
            queue.Enqueue("majestic");
            queue.Enqueue("sarjapur");

            foreach(String q in queue)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

        }
    }
}
