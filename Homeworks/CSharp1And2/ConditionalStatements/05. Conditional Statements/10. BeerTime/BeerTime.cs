//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        DateTime startBeerTime = DateTime.Parse("01:00 PM");
        DateTime endBeerTime = DateTime.Parse("03:00 AM");
        Console.WriteLine("Enter time (hh:mm tt; e.g. 11:00 PM) ");
        string inputTime = Console.ReadLine();
        try
        {

            DateTime inputTimeParsed = DateTime.ParseExact(inputTime, "h:mm tt", CultureInfo.InvariantCulture);
            bool evening = inputTimeParsed.TimeOfDay.CompareTo(startBeerTime.TimeOfDay) >= 0;
            bool morning = inputTimeParsed.TimeOfDay.CompareTo(endBeerTime.TimeOfDay) < 0;
            if (evening || morning)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

        }
        catch (Exception)
        {

            Console.WriteLine("Invalid time");
        }
    }
}

