using System;


class SortingArray
{
    //Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending / descending order.

    private static int[] PopulateArray() // this method populates the array.
    {
        Console.Write("Enter the number of the elements in the array: ");
        int numberOfElements = int.Parse(Console.ReadLine());
        int[] arrayOfIntegers = new int[numberOfElements];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            arrayOfIntegers[i] = int.Parse(Console.ReadLine());
        }
        return arrayOfIntegers;
    }

    private static int GetMaxValueFromAPosition(int[] array, int position) //This method gets the max value from input position.
    {
        int maxValue = int.MinValue;
        int bestPosition = position;
        for (int i = position; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                bestPosition = i;
            }
        }
        return bestPosition;
    }

    private static void SortTheArray(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        int tempNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int bestPosition = GetMaxValueFromAPosition(array, i);
            if (array[i] < array[GetMaxValueFromAPosition(array, i)])
            {
                tempNumber = array[i];
                array[i] = array[GetMaxValueFromAPosition(array, i)];
                array[bestPosition] = tempNumber;
            }
        }
    }

    private static void PrintTheArray(int[] array)
    {
        Console.Write("The array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = PopulateArray();
        Console.Write("Enter index where the search should start: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The max element from the portion is Element[{0}] = {1} !", GetMaxValueFromAPosition(array, index), array[GetMaxValueFromAPosition(array, index)]);
        SortTheArray(array);
        Console.Write("The array, sorted in descending type is :");
        PrintTheArray(array);
    }
}

