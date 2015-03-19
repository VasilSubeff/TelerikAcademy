using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.Write("Enter the lenght of the 1st array:");
        int length1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the lenght of the 2nd array:");
        int length2 = int.Parse(Console.ReadLine());
        char[] array1 = new char[length1];
        char[] array2 = new char[length1];
        bool compare = true;
        if (length1 == length2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Array 1, Element [{0}]: ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of array 2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Array 2, Element [{0}]: ", i);
                array2[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length1; i++)
            {
                if (array1[i] != array2[i])
                {
                    compare = false;
                }
            }
        }
        else
        {
            compare = false;
        }
        Console.WriteLine("Are the arrays equal ?");
        Console.WriteLine(compare);
    }
}

