using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Number of elemetns of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        //populating the array
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //solve the task
        int currentSum = 0;
        int startElement = 0;
        int endElement = 0;
        int i, j;
        for (i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            for (j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == s) // checking if the sum of the current selected elements is equal to S
                {
                    
                    startElement = i; // saves the 1st element of the max sum
                    endElement = j; // saves the last element of the max sum
                }
            }

            currentSum = 0;
        }

        //output
        Console.WriteLine("The sum we are looking for is {0}", s);
        Console.Write("It is found in the array and the elemets are ");
        for (int element = startElement; element <= endElement; element++)
        {
            Console.Write(array[element] + " ");
        }
        Console.WriteLine();
    }
}