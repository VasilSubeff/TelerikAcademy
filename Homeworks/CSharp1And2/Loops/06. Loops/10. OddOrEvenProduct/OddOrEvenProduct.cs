//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;


class OddOrEvenProduct
{
    static void Main()
    {
        Console.Write("Enter the numbers separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= Convert.ToInt32(numbers[i]);
            }
            else
            {
                evenProduct *= Convert.ToInt32(numbers[i]);
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("product = {0}", oddProduct);
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("Odd_product = {0}", oddProduct);
            Console.WriteLine("Even_product = {0}", evenProduct);
            Console.WriteLine("no");
        }

        
    }
}

