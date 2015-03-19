//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter 5 numbers, separated by space: ");
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine("The sum of the 5 numbers is " + sum);
        
    }
}

