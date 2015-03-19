//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Threading;
using System.Globalization;

class CirclePandS
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter radius: ");
        float radius = float.Parse(Console.ReadLine());
        Console.WriteLine("The area of the circle is {0:0.00} !", Math.PI* radius* radius);
        Console.WriteLine("The perimeter of the circle is {0:0.00} !", Math.PI * radius * 2);
    }
}

