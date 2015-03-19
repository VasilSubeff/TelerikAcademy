using System;

class ArrayBy5
{
    static void Main()
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}