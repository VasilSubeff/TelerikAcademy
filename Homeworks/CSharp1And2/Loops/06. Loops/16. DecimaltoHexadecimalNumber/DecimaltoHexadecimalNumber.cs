//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimaltoHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long number = long.Parse(Console.ReadLine());
        long countBits = number;
        int counterBits = 0;
        while (countBits > 0)
        {
            countBits /= 16;
            counterBits++;
        }
        char[] hexaNumber = new char[counterBits];
        for (int i = hexaNumber.Length - 1; i >= 0; i--)
        {
            long hex = (number % 16);

            switch (hex)
            {
                case 10: hex = 'A';
                    break;
                case 11: hex = 'B';
                    break;
                case 12: hex = 'C';
                    break;
                case 13: hex = 'D';
                    break;
                case 14: hex = 'E';
                    break;
                case 15: hex = 'F';
                    break;
                default:
                    hex = (char)(hex + 48);
                    break;

            }
            hexaNumber[i] = (char)hex;
            number /= 16;
        }
        Console.WriteLine(hexaNumber);
    }
}

