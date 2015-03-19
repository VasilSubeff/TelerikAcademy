//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        int product = 0;

        if (a != 0 && b != 0 && c != 0)
        {
            // The below 3 if statements check and count how many negative signs are entered.
            if (a < 0)
            {
                product++;
            }

            if (b < 0)
            {
                product++;
            }

            if (c < 0)
            {
                product++;
            }
            // The below if statement checks how many times the negavite sign is entered and prints the result depending on that.
            if (product == 2)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }

        }
        else
        {
            Console.WriteLine(product);
        }
    }
}
