//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;
        int a = 0;
        int b = 1;
        for (int i = 0; i < numberN; i++)
        {
            if (i == numberN - 1)
            {
                Console.Write(a); 
            }
            else
            {
                Console.Write(a + ", ");
            }
            sum = a + b;
            a = b;
            b = sum;
        }
        Console.WriteLine();
    }
}

