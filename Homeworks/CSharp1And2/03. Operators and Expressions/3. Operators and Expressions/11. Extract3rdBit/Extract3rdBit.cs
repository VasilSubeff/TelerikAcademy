//sing bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0

using System;

class Extract3rdBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;
        uint tempNumber = number & (mask << 3);
        tempNumber = tempNumber >> 3;
        Console.WriteLine("The 3rd bit of {0} is {1} !", number, tempNumber);

    }
}

