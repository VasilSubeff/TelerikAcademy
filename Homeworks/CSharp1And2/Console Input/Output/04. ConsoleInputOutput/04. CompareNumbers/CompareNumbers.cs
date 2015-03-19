//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Enter the 1st number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the 2st number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater of the two numbers is {0} !", number1 > number2 ? number1 : number2);
    }
}
