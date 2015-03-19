//Write a program that reads a string from the console and lists all 
//different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        CountDistinctWords(text);
    }

    private static void CountDistinctWords(string text)
    {
        string[] split = text.Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(split);

        List<string> distinctWords = new List<string>(split.Distinct());

        foreach (var word in distinctWords)
        {
            int counter = 0;

            for (int i = 0; i < split.Length; i++)
            {
                if (word == split[i])
                {
                    counter++;
                }
            }

            Console.WriteLine("{0} -> {1} times", word, counter);
        }
    }
}

