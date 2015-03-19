//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
class DateDiff
{
    static void Main()
    {
        Console.Write("Enter the first date (d.MM.yyyy): ");
        string firstDateInput = Console.ReadLine();
        Console.Write("Enter the second date (d.MM.yyyy): ");
        string secondDateInput = Console.ReadLine();

        DateTime firstDate = ParseDate(firstDateInput);
        DateTime secondDate = ParseDate(secondDateInput);

        double dateDiff = Math.Abs((firstDate - secondDate).TotalDays);

        Console.Write("There are {0} days between {1:d.MM.yyyy} and {2:d.MM.yyyy} !", dateDiff, firstDate, secondDate);
        Console.WriteLine();
    }

    //To change the date format - edit format variable value.
    private static DateTime ParseDate(string dateInput)
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime date = new DateTime();
        string format = "d.MM.yyyy";

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

