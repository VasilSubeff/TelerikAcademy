//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Threading;

class WordDictionary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to create your own dictiony or use the integrated one ?");
        Console.WriteLine("Choose 1 - Configure dictionary");
        Console.WriteLine("Choose 2 - Use integrated dictionary");
        Console.WriteLine("Make a choice: ");

        int choice = int.Parse(Console.ReadLine());
        Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        if (choice == 1)
        {
            EnterManuallyDictionaryRecords(dict);  
        }
        else if (choice == 2)
        {
            AutomaticDictionary(dict); 
        }
        else
        {
            Console.WriteLine("Invalid choice !");
        }

        FindValue(dict);
    }

    //Method to find the value when key asked in a spesific dictionary.
    private static void FindValue(Dictionary<string, string> dict)
    {
        Console.Write("Enter the word you are looking for: ");
        string lookup = Console.ReadLine();

        if (dict.ContainsKey(lookup))
        {
            string value = dict[lookup];
            Console.WriteLine("{0} - {1}", lookup, value);
        }
        else
        {
            Console.WriteLine("No such Key-Value pair in the dictionary !");

        }
    }

    //Integrated dictionary to use.
    private static Dictionary<string, string> AutomaticDictionary(Dictionary<string, string> dict1)
    {
        

        dict1.Add(".NET", "platform for applications from Microsoft");
        dict1.Add("CLR", "managed execution environment for .NET");
        dict1.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("The available Keys are: ");

        foreach (var key in dict1)
        {
            Console.WriteLine(key.Key);
        }
        return dict1;
    }

    //Configure your own dictionary with key-value paris
    private static Dictionary<string, string> EnterManuallyDictionaryRecords(Dictionary<string, string> dict)
    {
        Console.Write("How many elements do you want to add to the dictionary: ");
        int numberOfElements = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Key[{0}]: ", i + 1);
            string key = Console.ReadLine();
            Console.Write("Value[{0}]: ", i + 1);
            string value = Console.ReadLine();

            try
            {
                dict.Add(key, value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key \"{0}\" already exists !", key);
                Environment.Exit(0);
            }

        }

        return dict;
    }
}

