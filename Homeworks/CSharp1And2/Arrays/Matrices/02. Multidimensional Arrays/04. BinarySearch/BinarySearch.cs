//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Number of elemetns of the array (N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];


        // Populating the array.
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //sorting the array
        Array.Sort(array);

        //Finding the largest number <= k
        
        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }
        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}

