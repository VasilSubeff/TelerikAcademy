using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class RelevanceIndex
{
    static void Main()
    {
        string searchWord = Console.ReadLine();
        int numberOfParagraphs = int.Parse(Console.ReadLine());
        var paragraphs = new string[numberOfParagraphs];
        var pars = new List<string>();
        var row = new StringBuilder();

        for (int i = 0; i < numberOfParagraphs; i++)
        {
            paragraphs[i] = Console.ReadLine();
        }
        Console.WriteLine();
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < paragraphs.Length; i++)
        {
            int key = GetCountOfSubStrings(paragraphs[i], searchWord);
            dict.Add(paragraphs[i], key);
        }

        //var sortedDict = from entry in dict orderby entry.Value descending select entry;
        var sortedDict = dict.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key);
        
        foreach (var element in sortedDict)
        {
            var words = element.Key.Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].ToLower() == searchWord.ToLower())
                {
                    row.Append(words[j].ToUpper());

                }
                else
                {
                    row.Append(words[j]);
                }
                row.Append(" ");
            }

            pars.Add(row.ToString().Trim());
            row.Clear();
        }

        foreach (var par in pars)
        {
            Console.WriteLine(par);
        }

       
    }

    private static int GetCountOfSubStrings(string inputString, string substring)
    {
        int counter = 0;
        int startPos = 0;

        while (inputString.IndexOf(substring, startPos) >= 0)
        {
            startPos = inputString.IndexOf(substring, startPos);
            counter++;
            startPos += substring.Length;
        }
        return counter;
    }
}

