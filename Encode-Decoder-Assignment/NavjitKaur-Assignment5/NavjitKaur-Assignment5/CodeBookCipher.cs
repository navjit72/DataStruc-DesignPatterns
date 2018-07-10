using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment5
{
    class CodeBookCipher
    {
        static Dictionary<string, string> codebook = new Dictionary<string, string>();

        static List<string> cipherText = new List<string>();

        private static string KeyByValue(string text)
        {
            foreach(KeyValuePair<string,string> entry in codebook)
            {
                if (entry.Value.Equals(text))
                    return entry.Key;
            }
            return null;
        }

        public static void CreateCodeBook(string[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                codebook[arr[i]] = arr[i+1];
            }
        }

        public static void Decrypt(string message)
        {
            cipherText.Clear();
            string[] msg = message.Split(' ');
           
            foreach(string str in msg)
            {
                cipherText.Add(KeyByValue(str));
            }
        }

        public static void Encrypt(string message)
        {
            cipherText.Clear();
            string[] msg = message.Split(' ');
            foreach(string key in msg)
            {
                if(codebook.ContainsKey(key.ToLower()))
                    cipherText.Add(codebook[key.ToLower()]);
                else
                {
                    char[] charArray = key.ToLower().ToCharArray();
                    foreach (char ch in charArray)
                    { 
                        if(codebook.ContainsKey(ch+""))
                            cipherText.Add(codebook[ch+""]);
                    }
                }
            }
        }

        public static void DisplayList()
        {
            Console.WriteLine("Text : ");
            foreach(string value in cipherText)
            {
                Console.Write(value + " ");
            }
        }

    }
}
