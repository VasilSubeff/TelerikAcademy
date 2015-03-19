//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeros
{
    static BigInteger Factorial(int n)
    {
        BigInteger nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        return nFactorial;
    }
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result;
        result = Factorial(n);
        Console.WriteLine("{0}! = {1}", n, result);
        int counter = 0;
        int someResult;
        for (int i = 5; i <= n; i *= 5)
        {
            someResult = n / i;
            counter = counter + someResult;
        }
        if (counter == 1)
        {
            Console.WriteLine("There is {0} trailing zero at the end of {1}!", counter, n);
        }
        else
        {
            Console.WriteLine("There are {0} trailing zeroes at the end of {1}!", counter, n);
        }
    }

}

