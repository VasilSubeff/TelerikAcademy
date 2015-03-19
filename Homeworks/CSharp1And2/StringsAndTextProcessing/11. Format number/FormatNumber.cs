//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}->Decimal", number);
        Console.WriteLine("{0,15:X}->Hexadecimal", number);
        Console.WriteLine("{0,15:P}->Percentage", number);
        Console.WriteLine("{0,15:E}->Scientific notation", number);
    }
}

