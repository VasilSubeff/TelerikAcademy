using System;
using System.Collections.Generic;

namespace _08.SumTwoDIgitsofTwoArrays
{
    class SumTwoDIgitsofTwoArrays
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits 
        //(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
        //Each of the numbers that will be added could have up to 10 000 digits.


        static int GetTheNumberOfDigits(int number) // this method gets the length of the number
        {
            int numbersOfDigits = number;
            int counter = 0;
            while (numbersOfDigits != 0)
            {
                counter++;
                numbersOfDigits /= 10;
            }
            return counter;
        }
        static int[] PlaceTheDigitsInAnArray(int number) //this method places the digits in the array positions
        {
            int elementsOfTheArray = GetTheNumberOfDigits(number);
            int[] arrayOfIntegers = new int[elementsOfTheArray];
            int remainder = 0;
            int tempNumber = number;
            for (int i = 0; i < elementsOfTheArray; i++)
            {
                remainder = tempNumber % 10;
                arrayOfIntegers[i] = remainder;
                tempNumber /= 10;
            }

            return arrayOfIntegers;
        }
        private static void PrintList(List<int> listInMethod) // prints the final list
        {
            listInMethod.Reverse();
            for (int i = 0; i < listInMethod.Count; i++)
            {
                Console.Write(listInMethod[i]);
            }
        }
        private static List<int> SumTheArrays(int firstNumber, int secondNumber, int[] array1, int[] array2) //summs the array
        {
            List<int> listInMethod = new List<int>();
            int elementsOfList = GetTheNumberOfDigits(secondNumber);
            bool carry = false;
            for (int i = 0; i < elementsOfList; i++)
            {
                int tempNumber = 0;

                if (array1[i] + array2[i] >= 10)
                {
                    Console.WriteLine();

                    tempNumber = array1[i] + array2[i];
                    listInMethod.Add(tempNumber % 10);
                    tempNumber /= 10;
                    listInMethod.Add(tempNumber);
                    carry = true;
                    continue;
                }
                else if (carry)
                {
                    listInMethod[i] += array1[i] + array2[i];
                    carry = false;
                }
                else
                {
                    listInMethod.Add(array1[i] + array2[i]);
                }
            }
            int difference = GetTheNumberOfDigits(firstNumber) - GetTheNumberOfDigits(secondNumber); //this is if one of the numbers is longer.
            for (int i = 0; i < difference; i++)
            {
                listInMethod.Add(array1[GetTheNumberOfDigits(secondNumber) + i]);
            }
            return listInMethod;
        }
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int[] firstArray = PlaceTheDigitsInAnArray(number1);
            int[] secondArray = PlaceTheDigitsInAnArray(number2);
            List<int> list = new List<int>();
            if (GetTheNumberOfDigits(number1) > GetTheNumberOfDigits(number2))
            {
                list = new List<int>(SumTheArrays(number1, number2, firstArray, secondArray));
                PrintList(list);
            }
            else
            {
                list = new List<int>(SumTheArrays(number2, number1, secondArray, firstArray));
                PrintList(list);
            }
            Console.WriteLine();
        }
    }
}
