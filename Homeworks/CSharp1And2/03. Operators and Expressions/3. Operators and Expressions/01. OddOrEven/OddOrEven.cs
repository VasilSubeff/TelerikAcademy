//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0 && number != 0)
        {
            Console.WriteLine("The number is Even !");
        }
        else 
        {
            Console.WriteLine("The number is Odd !");
        }
    }
}

