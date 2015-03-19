//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number is divisible by 7 and 5 and the same time !");
        }
        else
        {
            Console.WriteLine("The number is NOT divisible by 7 and 5 at the same time");
        }
    }
}

