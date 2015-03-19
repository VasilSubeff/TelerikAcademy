//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class PlaywithIntDoubleandString
{
    static void Main()
    {
        Console.Write("Please choose a type (int/double/string): ");
        string type = Console.ReadLine();
        switch (type)
        {
            case "int":
                Console.Write("Please enter an integer: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt + 1);
                break;
            case "double":
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case "string":
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString + "*");
                break;
            default:
                break;
        }
    }
}

