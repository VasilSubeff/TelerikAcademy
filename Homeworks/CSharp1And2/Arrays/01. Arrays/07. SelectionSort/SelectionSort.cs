using System;

class SelectionSort
{
    static void Main()
    {
        //Initializing the array
        Console.Write("Number of elements of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int[] sortedArray = new int[length];

        //populating the arrays
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        int smallestNumber = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    smallestNumber = array[j];
                    array[j] = array[i];
                    array[i] = smallestNumber;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] +" ");
        }
    }
}

