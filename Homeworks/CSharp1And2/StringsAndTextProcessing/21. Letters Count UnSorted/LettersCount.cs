//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string text = "random letter at random some time are met";
        Console.WriteLine(text);
        string pattern = @"\w";

        MatchCollection letters = Regex.Matches(text, pattern);
        List<string> list = new List<string>();

        for (int i = 0; i < letters.Count - 1; i++)
        {
            list.Add(letters[i].ToString());
        }

        int counter = 1;

        while (list.Count > 0)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[0] == list[i])
                {
                    counter++;
                    list.RemoveAt(i);
                }

            }
            Console.WriteLine("{0} -> {1} times", list[0], counter);
            list.Remove(list[0]);
            counter = 1;
        }
    }
}

