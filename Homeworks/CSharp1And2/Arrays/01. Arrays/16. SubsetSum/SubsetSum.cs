//* We are given an array of integers and a number S. Write a program to find 
//if there exists a subset of the elements of the array that has a sum S. Example:
//arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class SubsetSum
{
    static void Main(string[] args)
    {
        Console.Write("Number of elemetns of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //populating the array
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //solve the task
        Console.Write("Enter the sum that you desire: ");
        int s = int.Parse(Console.ReadLine());
        string elemtnsOfTheSubSet = "";
        int currentSum = 0;
        int numberOfCombinations = (int)Math.Pow(2, n) - 1;
        int counter = 0;
        for (int i = 1; i <= numberOfCombinations; i++)
        {
            elemtnsOfTheSubSet = "";
            currentSum = 0;
            for (int j = 0; j <= n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum = currentSum + array[j];
                    elemtnsOfTheSubSet = elemtnsOfTheSubSet + " " + array[j];
                }
            }
            if (currentSum == s)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", s);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", s, elemtnsOfTheSubSet);
            }
        }
        Console.WriteLine("Theare re {0} subsets that are equal to {1} !", counter, s);
    }
}

