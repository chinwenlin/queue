using System;
using System.Collections.Generic;

namespace queuetest
{
    public class eGeneric
    {
        
        public static void EGeneric()
        {
            IList<int> intList = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                intList.Add(i*10);
                Console.WriteLine(intList.Count);
            }
            
        }
        public static void Main(string[] args){
            EGeneric();

            }

        
    }
}
