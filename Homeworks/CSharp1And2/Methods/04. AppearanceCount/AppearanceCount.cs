//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

namespace CountTheNumber
{
    public class AppearanceCount
    {
        // this method populates the array.
        public static int[] PopulateArray()
        {
            Console.Write("Enter the number of the elements in the array: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[numberOfElements];
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }
            return arrayOfIntegers;
        }

        // this method prints the array.
        public static void PrintArray(int[] arrayOfIntegers)
        {
            Console.Write("The array you have entered is: ");
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.Write(arrayOfIntegers[i] + " ");
            }
            Console.WriteLine();
        }

        //This method counts the appearances of the given number
        public static int CountTheAppearence(int[] arrayOfIntegers, int numberThatAppears)
        {
            int counter = 0;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == numberThatAppears)
                {
                    counter++;
                }
            }
            return counter;
        }


        public static void Main()
        {
            int[] array = PopulateArray();
            Console.Write("Enter a number to count the appearances: ");
            int number = int.Parse(Console.ReadLine());
            PrintArray(array);
            Console.WriteLine("The number {0} is met {1} times in the array !", number, CountTheAppearence(array, number));
        }
    }

}