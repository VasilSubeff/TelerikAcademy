//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        ExtractSentancesWithGivenWord(text, word);
    }

    private static void ExtractSentancesWithGivenWord(string text, string word)
    {
        StringBuilder result = new StringBuilder();

        string[] sentances = text.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (var sentance in sentances)
        {
            if (sentance.Contains(" " + word + " "))
            {
                result.Append(sentance + ". ");
            }
        }

        Console.WriteLine(result.ToString());
    }
}

