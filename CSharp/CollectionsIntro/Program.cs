using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           Arrays();
        }

        static void Arrays()
        {
            int[] intArr = new int[4]; 
            //multi-dimension array
            int [,] twoD = new int [3,2];
            
        }
        static void Lists()
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(2.22);

            int num = (int)list[0];

            //generic type
            List<int> list2 = new List<int>();
            list2.Add(2);
            int num2 = list2[0]; // dont need the type converter. compiler knows it is an int
        }
    
        static void otherCollections()
        {
            //sets -> has no defined order and no concepts of duplicates
            var set = new HashSet<string>{"a","b","a"};
            Console.WriteLine(set.Count);//2 not 3
            //NOTE: checking elements in list -> slow >< set: fast
            //the same insert and remove: set is faster

            //maps
            var dic = new Dictionary <int,string>{
                   [0] = "a",
                   [1] = "b" 
            };

            //in C#, string is based on value, not reference
            //we can overload operators (note recommend)

            var x = dic[1];

            //Stack, Queue
        }
    }
}
