//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int reminder = 0;
        for (int i = 0; i < 3; i++)
        {
            reminder = number % 10;
            number /= 10;
        }
        if (reminder == 7)
        {
            Console.WriteLine("The third digit (right to left) is 7 !");
        }
        else
        {
            Console.WriteLine("The third digit (right to left) is NOT 7 !");
        }
    }
}
