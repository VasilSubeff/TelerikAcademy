//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int givenInteger = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position that you want to check: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int bitValue = 0;
        do
        {
            Console.Write("Enter the value you want to change the bit to (0/1): ");
            bitValue = int.Parse(Console.ReadLine());
        } while (bitValue < 0 || bitValue > 1);
        int mask = 0;
        int result = 0;

        

        if (bitValue == 0)
        {
            mask = ~(1 << bitPosition);
            result = givenInteger & mask;     
        }
        if (bitValue == 1)
        {
            mask = 1 << bitPosition;
            result = givenInteger | mask;
        }

        Console.WriteLine();
        Console.WriteLine("The binary representation of {0} is {1}", givenInteger, Convert.ToString(givenInteger, 2).PadLeft(16, '0'));
        Console.WriteLine("After changing the {0} bit to {1}", bitPosition, bitValue);
        Console.WriteLine("The new number is {0} and its binary representation is {1}", result, Convert.ToString(result, 2).PadLeft(16, '0'));
    }
}
