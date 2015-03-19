//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long number = long.Parse(Console.ReadLine());
        long countBits = number;
        int counterBits = 0;
        while (countBits > 0)
        {
            countBits /= 2;
            counterBits++;
        }

        char[] binaryNumber = new char[counterBits];

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            binaryNumber[i] = (char)((number % 2) + 48);
            number /= 2;
        }
        Console.WriteLine(binaryNumber);
    }
}

