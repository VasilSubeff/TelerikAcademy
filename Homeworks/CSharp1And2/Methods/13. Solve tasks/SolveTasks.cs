//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

namespace Solve_tasks
{
    class SolveTasks
    {
        //Populates array
        public static int[] PopulateArray()
        {
            int numberOfElements = 0;
            do
            {
                Console.Write("Enter the number of the elements in the sequence (cannot be 0): ");
                numberOfElements = int.Parse(Console.ReadLine());
            } while (numberOfElements <= 0);
            
            int[] arrayOfIntegers = new int[numberOfElements];
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }
            return arrayOfIntegers;
        }

        //Reverses a number
        public static void ReverseTheNumber(decimal input)
        {
            string tempNumber = input.ToString();
            string reversedNumber = "";
            for (int i = tempNumber.Length - 1; i >= 0; i--)
            {
                reversedNumber += tempNumber[i];
            }
            Console.Write("The reversed number is {0}", reversedNumber);
            Console.WriteLine();
            Console.WriteLine("\n{0}\n", new string('-', 40));
        }

        //Calculates average of a sequence
        public static void CalculateAverage()
        {

            Console.WriteLine("\n{0}\n", new string('-', 40));

            int[] array = PopulateArray();
            decimal product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine();
            Console.WriteLine("The average of the sequence is {0}",product / array.Length);

            Console.WriteLine("\n{0}\n", new string('-', 40));
        }

        // Solve Linear Equation
        static void SolveLinearEquation()
        {
            Console.WriteLine("\n{0}\n", new string('-', 40));

            decimal a = 0;

            do
            {
                Console.Write("Enter a non-zero number A: ");
                a = decimal.Parse(Console.ReadLine());
            }
            while (a == 0);

            Console.Write("Enter a number B: ");
            decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nResult -> x = -b / a = {0}\n{1}\n", -b / a, new string('-', 40));
        }
        static void Main()
        {
            string userInput = "";
            do
            {
                Console.WriteLine("Please choose which task to solve:");
                Console.WriteLine("Reverse a number - type 1");
                Console.WriteLine("Calculate the average of a sequence - type 2");
                Console.WriteLine("Solve a quadratic equation - type 3");
                Console.WriteLine("To abort - type \"quit\"");
                Console.WriteLine();
                Console.Write("Please enter your choice: ");
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput == "1")
                {
                    decimal numberToReverse = 0;
                    do
                    {
                        Console.WriteLine("\n{0}\n", new string('-', 40));
                        Console.Write("Enter a positive number to reverse: ");
                        numberToReverse = decimal.Parse(Console.ReadLine());


                    } while (numberToReverse <= 0);
                    ReverseTheNumber(numberToReverse);
                }
                else if (userInput == "2")
                {
                    CalculateAverage();
                }
                else if (userInput == "3")
                {
                    SolveLinearEquation();
                }
                else if (userInput == "quit")
                {
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine();
                
            } while (true);
        }
    }
}
