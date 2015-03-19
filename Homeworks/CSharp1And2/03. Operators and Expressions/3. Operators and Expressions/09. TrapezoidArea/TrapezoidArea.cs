//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is {0} !", trapezoidArea);

    }
}

