/* We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***. */

using System;

class ForbiddenWords
{
    static void Main()
    {
        string exampleText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWordsList = { "PHP", "CLR", "Microsoft" };
        string expectedResult = "";

        foreach (var word in forbiddenWordsList)
        {
            exampleText = exampleText.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(exampleText);
    }
}

