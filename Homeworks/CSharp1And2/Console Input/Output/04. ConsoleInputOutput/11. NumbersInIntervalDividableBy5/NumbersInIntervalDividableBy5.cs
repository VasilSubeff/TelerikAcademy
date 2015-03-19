//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;
using System.Collections.Generic;

class NumbersInIntervalDividableBy5
{
    static void Main()
    {
        Console.Write("Enter start of the interval: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end of the interval: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Enter the number you want to divide on: ");
        int divideNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        List<int> numbers = new List<int>();
        
        for (int i = start; i <= end; i++)
        {
            if (i % divideNumber == 0)
            {
                counter++;
                numbers.Add(i);
            }
        }

        if (counter > 0)
        {
            Console.WriteLine("There are {0} numbers in the interval [{1}-{2}] that are divisible by {3} !", counter, start, end, divideNumber);
            Console.Write("Those numbers are: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        else
        {
            Console.Write("There are no numbers in the interval [{0}-{1}] that are divisible by {2} !", start, end, divideNumber);
        }
        Console.WriteLine();
        
    }
}

