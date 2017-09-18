using System;
using System.Collections.Generic;

namespace ProjectDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            //add more words to your dictionary
            //AddWord(Dictionary, "virag", "flower");
            //RemoveWord(Dictionary, "fa");
            //TranslateToEnglish(Dictionary, "alma");
            //TranslateToHungarian(Dictionary, "apple");

            Console.ReadLine();
        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(Dictionary<string, string> myDict, string hungarianWord, string englishWord)
        {
            myDict.Add(hungarianWord, englishWord);
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(Dictionary<string, string> myDict, string hungarianWord)
        {
            myDict.Remove(hungarianWord);
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "fa" and it's output is "tree"
        public static void TranslateToEnglish(Dictionary<string, string> myDict, string hungarian)
        {
            Console.WriteLine(myDict[hungarian]); 
            
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static void TranslateToHungarian(Dictionary<string, string> myDict, string english)
        {
            foreach (var element in myDict)
            {
                if (element.Value == english)
                {
                    Console.WriteLine(element.Key);
                }
            }
        }
    }
}
