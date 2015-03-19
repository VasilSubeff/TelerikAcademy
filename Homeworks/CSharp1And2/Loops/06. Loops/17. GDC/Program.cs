//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class GDC
{
    static void Main()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());
        if (a < b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        int reminder = 1;
        int c = 0;
        while (reminder != 0)
        {
            c = a / b;
            reminder = a % b;
            if (reminder == 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", a, b, c, reminder);
                Console.WriteLine("GCD = {0}", b);

            }
            else
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", a, b, c, reminder);
                a = b;
                b = reminder;
            }
        }
    }
}

