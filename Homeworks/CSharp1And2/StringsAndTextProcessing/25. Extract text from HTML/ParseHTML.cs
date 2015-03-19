/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ParseHTML
{
    static void Main(string[] args)
    {
        const string htmlDoc = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        string hTMLPattern = "<(.*?>)";
        string replacement = String.Empty;
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;

        //extracting the title
        string titleOpenTag = "<title>";
        string titleCloseTag = "</title>";
        int substringStartIndex = htmlDoc.IndexOf(titleOpenTag) + titleOpenTag.Length;
        int substringLength = htmlDoc.IndexOf(titleCloseTag) - ((htmlDoc.IndexOf(titleOpenTag) + titleCloseTag.Length) - 1);
        string title = htmlDoc.Substring(substringStartIndex, substringLength);

        //removing title from the original text
        string newHTML = htmlDoc.Remove(htmlDoc.IndexOf(title), title.Length);

        //adding space around the links
        while (newHTML.Contains("<a") || newHTML.Contains("a>"))
        {
            newHTML = newHTML.Replace("<a", " <b");
            newHTML = newHTML.Replace("a>", "b> ");
        }

        //removing the HTML tags
        string result = Regex.Replace(newHTML, hTMLPattern, replacement, options);
        result = result.Trim();

        Console.WriteLine("Title: " + title);
        Console.WriteLine("Text: " + result);
    }
}

