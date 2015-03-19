//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter an year: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year !", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year !", year);
            }

        }
    }
}
