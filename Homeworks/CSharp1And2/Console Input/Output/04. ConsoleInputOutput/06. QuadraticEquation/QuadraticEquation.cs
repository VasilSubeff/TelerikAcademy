//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        int a = 0;
        int b = 0;
        int c = 0;
        float d = 0;
        float x1 = 0;
        float x2 = 0;
        float x3 = 0;
        Console.Write("Enter a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        c = int.Parse(Console.ReadLine());
        d = (float)Math.Sqrt(b * b - 4 * a * c);
        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation !");
        }
        else
        {
            if (d >= 0)
            {
                if (d == 0)
                {
                    x3 = -b / (2 * a);
                    Console.WriteLine("There is only 1 real root and it is {0} !", x3);
                }
                else
                {
                    x1 = (-b + d) / (2 * a);
                    x2 = (b + d) / (2 * a);
                    Console.WriteLine("The real roots of the equation are {0} and {1} !", x1, x2);
                }
            }
            else
            {
                Console.WriteLine("There are no real roots");
            }
        }
    }
}

