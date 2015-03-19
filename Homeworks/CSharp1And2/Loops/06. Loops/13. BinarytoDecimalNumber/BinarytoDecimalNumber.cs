//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;


class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string inputBinaryString = Console.ReadLine();
        int counter = 0;
        long decimalResult = 0;
        for (int i = inputBinaryString.Length - 1; i >= 0; i--)
        {
            char bitString = inputBinaryString[i];
            decimalResult += (bitString-48) * (long)Math.Pow(2, counter);
            counter++;
        }
        Console.WriteLine(decimalResult); 
    }
}

