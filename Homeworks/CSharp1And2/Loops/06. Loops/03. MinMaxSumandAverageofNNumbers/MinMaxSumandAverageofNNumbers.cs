//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;


class MinMaxSumandAverageofNNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number[{0}]: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        decimal avg = 0m;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }

            if (max < numbers[i] )
            {
                max = numbers[i];
            }

            sum += numbers[i];

        }
        avg = (decimal)sum / (decimal)n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}

