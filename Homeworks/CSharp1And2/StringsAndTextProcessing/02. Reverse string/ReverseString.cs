using System;
using System.Text;

class ReverseString
{
    //Write a program that reads a string, reverses it and prints the result at the console.

    static void Main()
    {
        Console.Write("Enter string: ");
        string inputString = Console.ReadLine();
        StringBuilder reversed = new StringBuilder();

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversed.Append(inputString[i]);
        }

        Console.WriteLine(reversed.ToString());
    }
}

