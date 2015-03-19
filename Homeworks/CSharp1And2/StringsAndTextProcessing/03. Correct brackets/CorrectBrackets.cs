//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        
        int openBracket = 0;
        int index = expression.IndexOf("(");

        for (int i = index; i < expression.Length; i++)
        {
            if (expression[i].ToString() == "(")
            {
                openBracket++;
            }
            else if (expression[i].ToString() == ")")
            {
                openBracket--;
            }
        }

        if (openBracket == 0)
        {
            Console.WriteLine("The brackets are set correctly");
        }
        else
        {
            Console.WriteLine("The brackets are NOT set correctly");
        }

    }
}

