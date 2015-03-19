//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number N: ");
        int numberN = int.Parse(Console.ReadLine());
        double sum = 0D;

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter a number to be summed: ");
            double inputNumber = double.Parse(Console.ReadLine());
            sum += inputNumber;
        }
        Console.WriteLine("The sum of the entered numbers is " + sum);
    }
}

