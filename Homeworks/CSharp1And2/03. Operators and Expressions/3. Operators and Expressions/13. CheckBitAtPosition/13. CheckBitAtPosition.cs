//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int givenInteger = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position that you want to check: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1;
        int numberAndMask = 0;

        mask = mask << bitPosition;
        numberAndMask = (givenInteger & mask) >> bitPosition;

        Console.WriteLine(numberAndMask == 1 ? true : false);
    }
}

