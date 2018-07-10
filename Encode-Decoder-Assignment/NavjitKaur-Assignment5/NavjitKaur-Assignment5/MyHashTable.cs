using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment5
{
    //Question 1
    class MyHashTable
    {
        static Dictionary<string, string> hashTable = new Dictionary<string, string>();

        public static void AddData()
        {
            hashTable.Add("Josh", "Joshua Whitetail");
            hashTable.Add("Sam", "Samantha Bernie");
            hashTable.Add("Eli", "Elizabeth Spiegel");
            hashTable.Add("Will", "William Johnson");
            hashTable.Add("Don", "Donald Regan");
        }

        public static void DisplayData()
        {
            Console.WriteLine("Hash Table : ");
            foreach(KeyValuePair<string,string> entry in hashTable){
                Console.WriteLine(entry.Key + ":- " + entry.Value);
            }
        }
    }
}
