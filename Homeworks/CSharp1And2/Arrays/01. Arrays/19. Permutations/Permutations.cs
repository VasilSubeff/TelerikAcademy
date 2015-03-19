using System;

class Permutations
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4 };

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (i != j)
                {
                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
    }
}
