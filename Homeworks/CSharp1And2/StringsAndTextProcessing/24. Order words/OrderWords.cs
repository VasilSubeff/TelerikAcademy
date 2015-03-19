//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        SortTheWords(text);
    }

    private static void SortTheWords(string text)
    {
        string[] split = text.Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(split);

        for (int i = 0; i < split.Length; i++)
        {
            Console.WriteLine(split[i]);
        }
    }
}

