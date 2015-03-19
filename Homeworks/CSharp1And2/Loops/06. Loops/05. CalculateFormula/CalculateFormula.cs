//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateFormula
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        double s = 1;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += (double)factorial / (double)Math.Pow(x, i);
        }
        Console.WriteLine("{0:0.00000}", s);
    }
}

