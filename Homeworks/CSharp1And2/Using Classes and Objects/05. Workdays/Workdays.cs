//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Globalization;

class Workdays
{

    static void Main()
    {
        DateTime[] holidays = {new DateTime(2015, 1, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
            new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
            new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)};

        Console.Write("Enter a future date (yyyy/mm/dd): ");
        string inputDate = Console.ReadLine();
        DateTime currentDate = new DateTime();
        try
        {
            currentDate = DateTime.ParseExact(inputDate, "yyyy/MM/dd", CultureInfo.InvariantCulture);
        }
        catch (System.FormatException)
        {

            Console.WriteLine("Invalid date !");
            return;
        }

        Console.WriteLine("There are {0} working days between {1:yyy/MM/dd} and {2:yyy/MM/dd} !", CalculateWorkdays(DateTime.Now, currentDate, holidays), DateTime.Now, currentDate); 
    }

    private static int CalculateWorkdays(DateTime startDate, DateTime endDate, DateTime[] holidays)
    {
        int counter = 0;
        bool isHoliday = false;
        for (DateTime day = startDate; endDate.CompareTo(day) > 0; day = day.AddDays(1))
        {
            for (int i = 0; i < holidays.Length; i++)
            {
                if (day.CompareTo(holidays[i]) == 0)
                {
                    isHoliday = true;
                }
            }
            if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday && !isHoliday)
            {
                counter++;
            }
            isHoliday = false;
        }
        return counter;
    }
}

