using System;
using System.Collections.Generic;

class MaxIncreasingSequence
{
    static void Main()
    {
        //Initializing the array
        Console.Write("Number of elemetns of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int maxSequenceCounter = 1;
        int tempMaxSequenceCounter = 1;

        //populating the arrays
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //solve the task
        Console.WriteLine();
        List<int> tempSequence = new List<int>();
        List<int> incrSequence = new List<int>();

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i+1] - 1)
            {
                tempMaxSequenceCounter++;
                if (tempMaxSequenceCounter <= 2)
                {
                    tempSequence.Add(array[i]);
                    tempSequence.Add(array[i + 1]);
                }
                else
                {
                    tempSequence.Add(array[i + 1]);
                }
            }
            if (array[i] != array[i+1] - 1 || i == array.Length - 2)
            {
                if (tempMaxSequenceCounter > maxSequenceCounter)
                {
                    maxSequenceCounter = tempMaxSequenceCounter;
                    incrSequence = new List<int>(tempSequence);
                }
                tempMaxSequenceCounter = 1;
                tempSequence.Clear();
            }
        }
        Console.WriteLine("The max increasing sequence is formed by {0} elements !", maxSequenceCounter);
        Console.Write("Those elements are: ");
        foreach (var element in incrSequence)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


