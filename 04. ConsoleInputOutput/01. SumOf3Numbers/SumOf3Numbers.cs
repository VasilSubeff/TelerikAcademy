//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        int[] numbers = new int[3];
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("The Sum of the 3 numbers is " +sum);
    }
}

