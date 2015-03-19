//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers on 1 line, separated by a space: ");
        string inputNumbers = Console.ReadLine();
        Console.Write("The sum of the input numbers is: ");
        CalculateSum(inputNumbers);

    }

    private static void CalculateSum(string inputNumbers)
    {
        string[] numbers = inputNumbers.Split(' ');
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += int.Parse(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}

