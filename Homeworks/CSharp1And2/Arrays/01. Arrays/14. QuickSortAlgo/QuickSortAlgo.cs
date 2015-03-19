//Write a program that sorts an array of strings 
//using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSortAlgo
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
        int startElement = 0;
        int endElement = n - 1;
        int[] secondaryArray = new int[n * 2];

        //solve the task by declaring another array with double size than the first one, 
        //and counting the positions on the left and on the right from the middle of the new array
        while (true)
        {
            int pivot = array[startElement];
            secondaryArray[secondaryArray.Length / 2] = array[startElement];
            int leftElementCounter = 0;
            int rightElementCounter = 0;
            for (int i = startElement + 1; i <= endElement; i++)
            {
                if (pivot < array[i])
                {
                    leftElementCounter++;
                    secondaryArray[n + leftElementCounter] = array[i];
                }
                else if (pivot > array[i])
                {
                    rightElementCounter++;
                    secondaryArray[n - rightElementCounter] = array[i];
                }
            }

            //transfer data to 1st array;
            int helper = 0;
            for (int i = startElement; i <= array.Length - 1; i++)
            {
                array[i] = secondaryArray[n - rightElementCounter + helper];
                helper++;
            }

            //check if the array is sorted.
            int checker = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    startElement = i;
                    break;
                }
                else if (array[i] < array[i + 1])
                {
                    checker++;
                }
            }
            if (checker == n - 1)
            {
                break;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

    }
}

