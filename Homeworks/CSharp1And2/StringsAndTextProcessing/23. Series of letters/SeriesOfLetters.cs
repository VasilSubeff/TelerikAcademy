//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        //string text = "aaaaabbbbbcdddeeeedssaa";
        string replacement = "$1";
        string pattern = @"(.)\1+";
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;

        string result = Regex.Replace(text, pattern, replacement, options);
        Console.WriteLine(result);

        
    }
}

