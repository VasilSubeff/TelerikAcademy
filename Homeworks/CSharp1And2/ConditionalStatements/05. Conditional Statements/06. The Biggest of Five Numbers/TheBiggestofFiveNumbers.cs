//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter the 1st number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the 2nd number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the 3rd number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter the 4th number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter the 5th number: ");
        int e = int.Parse(Console.ReadLine());
        int greatestNumber = a;

        if (greatestNumber < b)
        {
            greatestNumber = b;
        }
        if (greatestNumber < c)
        {
            greatestNumber = c;
        }
        if (greatestNumber < d)
        {
            greatestNumber = d;
        }
        if (greatestNumber < e)
        {
            greatestNumber = e;
        }
        Console.WriteLine("The greatest number is {0}", greatestNumber);
    }
}
