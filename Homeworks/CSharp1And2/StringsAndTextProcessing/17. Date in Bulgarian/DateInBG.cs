//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class DateInBG
{
    static void Main()
    {
        Console.Write("Enter the first date (d.MM.yyyy HH:mm:ss): ");
        string inputDate = Console.ReadLine();
        DateTime originalDate = ParseDate(inputDate);
        
        CultureInfo culture = new CultureInfo("bg-BG");
        string dayOfTheWeek = culture.DateTimeFormat.GetDayName(originalDate.DayOfWeek);

        originalDate = originalDate.AddHours(6).AddMinutes(30);

        Console.WriteLine("After 6 hours and 30 minutes the time will be {0:d.MM.yyyy HH:mm:ss}", originalDate);
        Console.WriteLine(dayOfTheWeek); // Вторник
        
    }

    public static DateTime ParseDate(string dateInput)
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime date = new DateTime();
        string format = "d.MM.yyyy HH:mm:ss";

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

