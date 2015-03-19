//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string inputHexaString = Console.ReadLine().ToUpper();
        int counter = 0;
        long decimalResult = 0;
        for (int i = inputHexaString.Length - 1; i >= 0; i--)
        {
            char bitString = inputHexaString[i];
            int bit = 0;
            switch (bitString)
	        {
                case 'A': bit = 10;
                    break;
                case 'B': bit = 11;
                    break;
                case 'C': bit = 12;
                    break;
                case 'D': bit = 13;
                    break;
                case 'E': bit = 14;
                    break;
                case 'F': bit = 15;
                    break;
                default: bit = bitString - 48;
                    break;
	        }
            decimalResult += bit * (long)Math.Pow(16, counter);
            counter++;
        }
        Console.WriteLine(decimalResult); 
    }
}
    

