//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string text = "random text ABBA, random text lamal, random text exe random text!";
        string pattern = @"\b\w+\b";
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;
        MatchCollection words = Regex.Matches(text, pattern, options);

        Console.WriteLine("The palindromes found in the text are:");

        foreach (var word in words)
        {
            if (word.ToString() == ReverseString(word.ToString()))
            {
                Console.WriteLine(word);
            }
        }
    }

    private static string ReverseString(string original)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed.Append(original[i]);
        }
        return reversed.ToString();
    }
}

