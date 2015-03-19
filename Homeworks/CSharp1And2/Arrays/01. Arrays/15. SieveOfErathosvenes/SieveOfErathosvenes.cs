using System;
using System.Collections.Generic;

class SieveOfErathosphenes
{
    static void Main(string[] args)
    {
        Console.Write("Number of elemetns of the array: ");
        long n = long.Parse(Console.ReadLine());
        long[] array = new long[n];

        //populating the array
        for (long elements = 0; elements < array.Length; elements++)
        {
            array[elements] = elements + 1;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if ((array[i] % 2 == 0 && array[i] != 2) || (array[i] % 3 == 0 && array[i] != 3) ||
                (array[i] % 5 == 0 && array[i] != 5) || (array[i] % 7 == 0 && array[i] != 7))
            {
                array[i] = 0;
            }
        }
        List<long> listOfIntegers = new List<long>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                listOfIntegers.Add(array[i]);
            }
        }
        foreach (int primeNumber in listOfIntegers)
        {
            Console.Write(primeNumber + " ");
        }
    }
}

