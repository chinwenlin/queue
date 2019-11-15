using System;
using System.Collections;
using System.Collections.Generic;

namespace queuetest
{
    
    
        
        
    
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue("abc");
            queue.Enqueue("efg");

            Hashtable ht = new Hashtable();
            ht.Add(1, "A");
            ht.Add(2, "B");
            ht.Add(3, "C");
            string s1 = (string)ht[1];
            string s2 = ht[2].ToString();


            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht2 = new Hashtable(dict);


            Console.WriteLine("total element:{0}", ht2.Count);

            Console.WriteLine("------------------");
            EGeneric();


            Console.WriteLine("------------------");
            Console.WriteLine(s1);
            Console.WriteLine(s2);



            Console.WriteLine("------------------");
            Console.WriteLine("The total object in the queue is " + queue.Count);
            Console.WriteLine("the total value in the hashtable is " + ht.Count);
        }
        public static void EGeneric()
        {
            IList<int> intList = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                intList.Add(i * 10);
                Console.WriteLine(intList.Count);
            }

        }


    }
}
