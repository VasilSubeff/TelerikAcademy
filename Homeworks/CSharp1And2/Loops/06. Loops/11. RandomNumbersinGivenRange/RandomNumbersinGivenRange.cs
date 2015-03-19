//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersinGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()); 
        int min, max;
        do
        {
            Console.WriteLine("Enter max and min (Min <= Max) !");
            Console.Write("Enter min: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Enter max: ");
            max = int.Parse(Console.ReadLine());
            
        } while (min >= max);

        Random random = new Random();
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(min, max + 1);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

    }
}

