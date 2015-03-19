using System;
using System.Collections.Generic;

class MaxSumOfKElements
{
    static void Main()
    {
        //Initializing the array
        Console.Write("Number of elements of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        //populating the arrays
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //solve task
        Console.WriteLine();
        int sum = 0;
        int maxSum = 0;
        List<int> tempSequence = new List<int>();
        List<int> maxSequence = new List<int>();
        for (int i = 0; i < array.Length - k + 1; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sum += array[i + j];
                tempSequence.Add(array[i + j]);
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxSequence = new List<int>(tempSequence);
                
            }
            sum = 0;
            tempSequence.Clear();
        }

        Console.WriteLine("The max Sum of {0} elements is {1} !", k, maxSum);
        Console.Write("Those elements are: ");
        foreach (var element in maxSequence)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    
    }
}

