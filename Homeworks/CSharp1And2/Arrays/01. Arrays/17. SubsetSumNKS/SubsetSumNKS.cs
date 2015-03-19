//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetSumNKS
{
    static void Main(string[] args)
    {
        Console.Write("Number of elemetns of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the how many elements should be the subset: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum that you desire: ");
        int s = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //populating the array
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //solve the task
        //It is the same as 16, but here we add kCounter and if the count of the elements are not equal to K it does not print the subset.
        string elemtnsOfTheSubSet = "";
        int currentSum = 0;
        int numberOfCombinations = (int)Math.Pow(2, n) - 1;
        int counter = 0;
        int kCounter = 0;
        for (int i = 1; i <= numberOfCombinations; i++)
        {
            kCounter = 0;
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
                    kCounter++;

                }

            }
            if (currentSum == s && k == kCounter)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", s);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", s, elemtnsOfTheSubSet);
            }
        }
        Console.WriteLine("Theare re {0} subsets that are equal to {1} !", counter, s);
    }
}

