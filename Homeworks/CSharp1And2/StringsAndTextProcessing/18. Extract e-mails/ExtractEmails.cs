//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = @"My main email is main.email@domain.com and my secondary email is secondary@anotherdomain.net 
                      so I can use them both and send to my third email my.third.email@thirddomain.com !";

        string pattern = @"\w*\S*\w*@\w*.\w*";
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;

        MatchCollection matches = Regex.Matches(text, pattern, options);

        Console.WriteLine("{0} emails have been found in the text and they are: ", matches.Count);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

