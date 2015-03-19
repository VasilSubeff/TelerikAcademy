//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;


class CanadaDates
{
    static void Main()
    {
        string text = "Dwayne Douglas Johnson was born 02.05.1972. The Rock gained fame in WWE from 03.1996 to 03/2004.";
        string pattern = "[0-9]{2}.[0-9]{2}.[0-9]{4}";
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;
        MatchCollection matches = Regex.Matches(text, pattern, options);

        Console.WriteLine("The found dates in the text are:");

        foreach (var match in matches)
        {
            DateTime date = ParseDate(match.ToString());
            Console.WriteLine("{0}", date.ToString("d"));    
        }
    }

    public static DateTime ParseDate(string dateInput)
    {
        CultureInfo provider = new CultureInfo("en-CA");
        DateTime date = new DateTime();
        string format = "dd.MM.yyyy";

        try
        {
            date = DateTime.ParseExact(dateInput, format, provider);

        }
        catch (System.FormatException)
        {

            Console.WriteLine("Invalid date !");
            Environment.Exit(0);
        }
        return date;
    }
}

