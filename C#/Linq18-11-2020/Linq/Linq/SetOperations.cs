using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class SetOperations
    {
        public static void setoperations()
        {
            String[] s1 = { "ravi", "ramesh", "mahesh", "varun", "praveen" };
            String[] s2 = { "varun", "pavan", "reddy", "ravi", "mahesh" };

            var uniontype = s1.Union(s2);
            Console.WriteLine("union elements are");
            foreach(string s in uniontype)
            {
                Console.Write(s + " ");
            }

            var intersecttype = s1.Intersect(s2);
            Console.WriteLine("intersect elements are");
            foreach (string s in intersecttype)
            {
                Console.Write(s + " ");
            }

            var distincttype = s1.Distinct();
            Console.WriteLine("distinct elements are");
            foreach (string s in distincttype)
            {
                Console.Write(s + " ");
            }

            var excepttype = s1.Except(s2);
            Console.WriteLine("except elements are");
            foreach (string s in excepttype)
            {
                Console.Write(s + " ");
            }

            var contacttype = s1.Concat(s2);
            Console.WriteLine("concat elements are");
            foreach (string s in contacttype)
            {
                Console.Write(s + " ");
            }

            var sequenceequal = s1.SequenceEqual(s2);
            Console.WriteLine("elements sequention" + sequenceequal);
            

        }
    }
}
