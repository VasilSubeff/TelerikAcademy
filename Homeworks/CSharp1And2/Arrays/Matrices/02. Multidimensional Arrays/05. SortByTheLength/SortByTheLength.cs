//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;

class SortByTheLength
{
    public static int CountTheLetters(string arrayElement) // this method counts the words in every word (element from the string array)
    {
        string word = arrayElement;
        int counter = 0;
        foreach (char letter in word)
        {
            counter++;
        }
        return counter;
    }
    public static string[] SortTheStrings(string[] stringArray) // this method sorts the elemts by their length
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            for (int j = 0; j < stringArray.Length; j++)
            {
                if (CountTheLetters(stringArray[i]) < CountTheLetters(stringArray[j]))
                {
                    string temp = stringArray[i];
                    stringArray[i] = stringArray[j];
                    stringArray[j] = temp;
                }
            }

        }
        return stringArray;
    }
    static void Main(string[] args)
    {
        Console.Write("Number of elemetns of the array (N): ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];


        // Populating the array.
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array 1, Element [{0}]: ", elements);
            array[elements] = Console.ReadLine();
        }
        Console.WriteLine();
        //this is the default array
        Console.WriteLine("This is the default array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element[{0}] = {1}", i, array[i]);
        }
        Console.WriteLine();
        //pint out every element and its length
        for (int i = 0; i < array.Length; i++)
        {
            int number = CountTheLetters(array[i]);
            Console.WriteLine("{0} = {1} letters", array[i], number);
        }
        Console.WriteLine();
        SortTheStrings(array); // sorts the array.

        // prints the elements by their length - ascending.
        Console.WriteLine("This is the sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element[{0}] = {1}", i, array[i]);
        }
    }
}

