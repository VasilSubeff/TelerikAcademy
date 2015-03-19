//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    public static void ReturnLastDigitAsAWord(int number)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int lastDigit = number % 10;
        Console.WriteLine(words[lastDigit]);
        
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int chislo = int.Parse(Console.ReadLine());

        ReturnLastDigitAsAWord(chislo);
    }
}

