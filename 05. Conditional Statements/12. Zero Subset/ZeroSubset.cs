//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

using System;

class ZeroSubset
{
    static void Main()
    {
        int counter = 0;
        int integerCount = 5;
        int[] intArray = new int[integerCount];
        for (int i = 0; i < integerCount; i++)
        {
            Console.Write("Enter value {0}: ", i + 1);
            intArray[i] = int.Parse(Console.ReadLine());
        }
        int maxI = (int)(Math.Pow((double)2, integerCount) - 1);
        for (int i = 1; i <= maxI; i++)
        {
            int currenctSum = 0;
            for (int j = 0; j <= integerCount; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currenctSum = currenctSum + intArray[j];
                }
            }
            if (currenctSum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("There are {0} subsets whose sum is 0 !", counter);
    }
}

