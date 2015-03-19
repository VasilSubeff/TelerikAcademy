//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestof3Numbers
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }

    }
}

