//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder uppercaseText = new StringBuilder();

        ConvertTaggedToUppercase(text, uppercaseText);
    }

    private static void ConvertTaggedToUppercase(string text, StringBuilder uppercaseText)
    {
        int startPos = 0;
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        int countOfTags = GetCountOfSubStrings(text, openTag);

        for (int i = 0; i < countOfTags + 1; i++)
        {

            int openTagIndex = text.IndexOf("<upcase>", startPos);
            int closeTagIndex = text.IndexOf("</upcase>", startPos);
            int startIndexUpperCase = openTagIndex + openTag.Length;
            int countOfUpperCases = closeTagIndex - (openTagIndex + closeTag.Length - 1);
            int countOfLowerCases = openTagIndex - startPos;

            if (closeTagIndex > 0)
            {

                uppercaseText.Append(text.Substring(startPos, countOfLowerCases));
                uppercaseText.Append(text.Substring(startIndexUpperCase, countOfUpperCases).ToUpper());
                startPos = closeTagIndex + closeTag.Length;
            }
            else
            {
                uppercaseText.Append(text.Substring(startPos, text.Length - startPos));
            }
        }

        Console.WriteLine(uppercaseText.ToString());
    }

    private static int GetCountOfSubStrings(string inputString, string substring)
    {
        int counter = 0;
        int startPos = 0;

        while (inputString.IndexOf(substring, startPos) > 0)
        {
            startPos = inputString.IndexOf(substring, startPos);
            counter++;
            startPos += substring.Length;
        }

        return counter;
    }
}

