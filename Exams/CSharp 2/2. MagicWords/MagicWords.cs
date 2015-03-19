using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        
        for (int i = 0; i < numberOfWords; i++)
        {
            words.Add(Console.ReadLine());
        }
        Console.WriteLine();

        //reorder
        for (int i = 0; i < numberOfWords; i++)
        {
            var word = words[i];
            var newIndex = word.Length % (numberOfWords + 1);

            words.Insert(newIndex, word);
            if (newIndex < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
            
        }

        //print
        int maxLen = 0;

        foreach (var word in words)
        {
            if (word.Length > maxLen)
            {
                maxLen = word.Length;
            }
        }

        var result = new StringBuilder();

        for (int i = 0; i < maxLen; i++)
        {
            foreach (var word in words)
            {
                if (i < word.Length)
                {
                    result.Append(word[i]);
                }
            }
        }

        Console.WriteLine(result);
    }
}

