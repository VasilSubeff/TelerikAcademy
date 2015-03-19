using System;

class MostFrequentNumber
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

        //solve task
        int counter = 1;
        int maxCounts = 0;
        int freqElement = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
                if (counter > maxCounts)
                {
                    maxCounts = counter;
                    freqElement = array[i];
                }
                
            }
            counter = 1;
        }
        Console.WriteLine("{0} -> {1} times", freqElement, maxCounts);
    }
}

