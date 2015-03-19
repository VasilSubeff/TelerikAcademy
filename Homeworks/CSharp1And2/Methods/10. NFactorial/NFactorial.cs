using System;
using System.Numerics;

class NFactorial
    
{
    //Write a program to calculate n! for each n in the range [1..100].
    //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
    

    //Populates the array
    public static int[] PopulateTheArray(int elements)
    {
        int[] array = new int[elements];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    //Calculate NFactoriel
    public static BigInteger MultiplyTheElements(int elements)
    {
        int[] array = PopulateTheArray(elements);
        BigInteger nFact = 1;
        for (int i = 0; i < array.Length; i++)
        {
            nFact *= array[i];
        }
        return nFact;

    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}",i, MultiplyTheElements(i));
        }

    }
}

