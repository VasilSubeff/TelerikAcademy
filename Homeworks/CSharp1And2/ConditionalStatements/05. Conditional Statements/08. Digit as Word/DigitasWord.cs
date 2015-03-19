//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

using System;

class DigitasWord
{
    static void Main()
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 0:
                Console.WriteLine(words[number]);
                break;
            case 1:
                Console.WriteLine(words[number]);
                break;
            case 2:
                Console.WriteLine(words[number]);
                break;
            case 3:
                Console.WriteLine(words[number]);
                break;
            case 4:
                Console.WriteLine(words[number]);
                break;
            case 5:
                Console.WriteLine(words[number]);
                break;
            case 6:
                Console.WriteLine(words[number]);
                break;
            case 7:
                Console.WriteLine(words[number]);
                break;
            case 8:
                Console.WriteLine(words[number]);
                break;
            case 9:
                Console.WriteLine(words[number]);
                break;
            default:
                Console.WriteLine("not a digit");
                break;
        }
    }
}

