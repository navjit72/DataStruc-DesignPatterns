using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment5
{
    //Question 2
    class MyHashSet
    {
        static HashSet<string> hashSet = new HashSet<string>();
        static Dictionary<string, int> myDic = new Dictionary<string, int>();

        public static void AddData(string[] arr)
        {
            foreach(string value in arr)
            {
                hashSet.Add(value);
            }
        }

        public static void DisplayData()
        {
            Console.WriteLine("Number of unique strings : " + hashSet.Count);
            Console.WriteLine("Hash Set : ");
            foreach(string value in hashSet)
            {
                if (hashSet.ElementAt(hashSet.Count-1).Equals(value))
                    Console.Write(value);
                else
                    Console.Write(value+ ",");
            }
        }

        public static void CountOccurences(string[] arr)
        {
            
            int[] count = new int[hashSet.Count];
            foreach(string value in hashSet)
            {
                myDic.Add(value, 0);
            }
            foreach(string x in arr)
            {
                int value = 0;
                if (myDic.ContainsKey(x))
                {
                    value = myDic[x] + 1;
                    myDic[x] = value;
                }
            }
        }

        public static void DisplayOccurences()
        {
            foreach(KeyValuePair<string,int> entry in myDic)
            {
                Console.WriteLine(entry.Key + ":- " + entry.Value + " occurences");
            }
        }
    }
}
