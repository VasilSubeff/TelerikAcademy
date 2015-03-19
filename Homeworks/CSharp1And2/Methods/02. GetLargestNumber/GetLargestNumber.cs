//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    public static int GetMax(int number1, int number2)
    {
        int bigger = number1;
        if (number1 < number2)
        {
            bigger = number2;
        }
        return bigger;
    }
    static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            int inputNumber = int.Parse(Console.ReadLine());
            numbers[i] = inputNumber;
        }

        Console.WriteLine("The largest number is {0} !", GetMax(GetMax(numbers[0], numbers[1]), numbers[2]));
    }
}
