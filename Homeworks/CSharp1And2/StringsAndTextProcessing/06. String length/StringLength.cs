//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;


class StringLength
{
    static void Main()
    {
        const int maxElements = 20;
        string input = "";
        char filler = '*';
        StringBuilder filledString = new StringBuilder();
        
        do
        {
            Console.Write("Enter string with max 20 elements: ");
            input = Console.ReadLine();
        } while (input.Length > maxElements);

        if (input.Length < maxElements)
        {
            filledString.Append(input);
            filledString.Append(new string(filler, maxElements - input.Length));
        }

        Console.WriteLine(filledString.ToString());
    }
}

