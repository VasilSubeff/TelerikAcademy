//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 100 : ");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i < 101; i++)
        {
            if (number % i == 0)
            {
                counter++;
            }
        }
        if (counter == 2 && number > 0)
        {
            Console.WriteLine("The number is prime !");
        }
        else
        {
            Console.WriteLine("The number is NOT prime !");
        }
    }
}
