using System;


class CompareArrays
{
    static void Main()
    {
        //Initializing the array
        Console.Write("Number of elemetns of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array1 = new int[length];
        int[] array2 = new int[length];

        //populating the arrays
        for (int elements = 0; elements < array1.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array1[elements] = inputNumber;
        }

        //populating the arrays
        for (int elements = 0; elements < array2.Length; elements++)
        {
            Console.Write("Array 2, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array2[elements] = inputNumber;
        }

        bool equalArrays = true;
        //compare the arrays
        for (int i = 0; i < length; i++)
        {
            if (array1[i] != array2[i])
            {
                equalArrays = false;
            }
        }
        if (equalArrays)
        {
            Console.WriteLine("The arrays are equal !");
        }
        else
        {
            Console.WriteLine("The arrays are not equal !");
        }
    }
}

