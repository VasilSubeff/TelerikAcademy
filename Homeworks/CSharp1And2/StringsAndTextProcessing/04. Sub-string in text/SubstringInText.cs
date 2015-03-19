//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;

class SubstringInText
{
    static void Main()
    {
        //Console.Write("Enter a string :");
        //string inputString = Console.ReadLine();
        //Console.Write("Enter sub-string: ");
        //string substring = Console.ReadLine();
        string inputString = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        GetCountOfSubStrings(inputString, substring);
    }

    private static void GetCountOfSubStrings(string inputString, string substring)
    {
        int counter = 0;
        int startPos = 0;

        while (inputString.IndexOf(substring, startPos) >= 0)
        {
            startPos = inputString.IndexOf(substring, startPos);
            counter++;
            startPos += substring.Length;
        }
        Console.WriteLine(counter);
    }
}

