//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = 0;
        do
	    {
	       Console.Write("Enter a 4-digit number: ");
            number = int.Parse(Console.ReadLine());  
	    } while (number.ToString().Length != 4);
        
        //The sum of the four digits.
        int numberForSumming = number;
        int sum = 0;
        while (numberForSumming != 0)
        {
            sum = sum + (numberForSumming % 10);
            numberForSumming /= 10;
        }
        Console.WriteLine("The sum of the 4 digits is {0} !",sum);

        //Print the reversed number
        int numberForReversing = number;
        string reversedNumber = "";
        int reminderForReversedNumber = 0;
        while (numberForReversing != 0)
        {
            reminderForReversedNumber = numberForReversing % 10;
            numberForReversing /= 10;
            reversedNumber += reminderForReversedNumber.ToString();
        }
        Console.WriteLine("The reversed number is {0} !", reversedNumber);

        //Last digit first.
        int numberForLastDigitFirst = number;
        string lastDigitFirst = (numberForLastDigitFirst % 10).ToString() + (numberForLastDigitFirst / 10).ToString();
        Console.WriteLine("When the last digit goes first, the number is " + lastDigitFirst);

        // Exchange second and third digits.
        char[] exchangeNumber = number.ToString().ToCharArray();
        char[] exchangeTempResult = new char[exchangeNumber.Length];
        for (int i = 0; i < exchangeNumber.Length; i++)
        {
            if (i == 1)
            {
                exchangeTempResult[i] = exchangeNumber[i + 1];
            }
            else if (i == 2)
            {
                exchangeTempResult[i] = exchangeNumber[i - 1];
            }
            else
            {
                exchangeTempResult[i] = exchangeNumber[i];
            }
        }
        string resultOfTheExchange = new string(exchangeTempResult);
        Console.WriteLine("When the 2nd and the 3rd digits are exchanged, the number is " + resultOfTheExchange);
    }
}
