//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class Largerthanneighbours
{
    // this method populates the array.
    public static int[] PopulateArray()
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

    // this method prints the array.
    public static void PrintArray(int[] arrayOfIntegers)
    {
        Console.Write("The array you have entered is: ");
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            Console.Write(arrayOfIntegers[i] + " ");
        }
        Console.WriteLine();
    }

    // This method checks if the element at the selected position is bigger than its two neighbours
    // If there are no two neighbours, it says so and it does not check further.
    private static void CheckTheNeighbours(int[] array) 
    {
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());


        if (position > 0 && position < array.Length - 1)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("The element at position {0} in the array is bigger than its two neighbours !", position);
            }
            else
            {
                Console.WriteLine("The element at position {0} in the array is not bigger than its two neighbours !", position);
            }
        }
        else
        {
            Console.WriteLine("The element that you have selected does not have 2 neighbours");
        }
    }
    static void Main()
    {
        int[] array = PopulateArray();
        PrintArray(array);
        CheckTheNeighbours(array);
    } 
}

