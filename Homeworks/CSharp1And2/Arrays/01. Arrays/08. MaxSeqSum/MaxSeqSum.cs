using System;

class MaxSeqSum
{
    static void Main()
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
        int currentSum = 0;
        int maxSum = 0;
        int startElement = 0;
        int endElement = 0;
        int i, j;
        for (i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            for (j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum > maxSum) // checking if the sum of the current selected elements is bigger than the last maximum sum
                {
                    maxSum = currentSum;
                    startElement = i; // saves the 1st element of the max sum
                    endElement = j; // saves the last element of the max sum
                }
            }

            currentSum = 0;
        }

        //output
        Console.WriteLine("The maximum sum is {0}", maxSum);
        Console.Write("The sequence that makes the maximum sum is ");
        for (int element = startElement; element <= endElement; element++)
        {
            Console.Write(array[element] + " ");
        }
        Console.WriteLine();
    }
}