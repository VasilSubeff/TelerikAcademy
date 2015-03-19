//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{

    public static void ReverseTheNumber(int input)
    {
        Console.Write("The random generated number is: {0}", input);
        Console.WriteLine();
        string tempNumber = input.ToString();
        string reversedNumber = "";
        for (int i = tempNumber.Length - 1; i >= 0; i--)
        {
            reversedNumber += tempNumber[i];
        }
        Console.Write("When it is reversed, it becomes {0}", reversedNumber);
        Console.WriteLine();
    }

    static void Main()
    {
        Random number = new Random();
        ReverseTheNumber(number.Next(10000));
    }
}

