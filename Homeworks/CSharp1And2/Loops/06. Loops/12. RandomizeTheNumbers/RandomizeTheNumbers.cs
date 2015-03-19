//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order

using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Random random = new Random();
        int k = array.Length;
        while (k > 1)
        {
            k--;
            int i = random.Next(n);
            int temp = array[i];
            array[i] = array[k];
            array[k] = temp;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

