using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class NineGag
{
    public static int ConvertTheNumbers(string bit)
    {
        switch (bit)
        {
            case "-!": return 0;
            case "**": return 1;
            case "!!!": return 2;
            case "&&": return 3;
            case "&-": return 4;
            case "!-": return 5;
            case "*!!!": return 6;
            case "&*!": return 7;
            case "!!**!-": return 8;
            default:
                return -1;
        }


        return -1;
    }
    private static BigInteger Power(int power)
    {
        BigInteger powered = 1;

        for (int i = 0; i < power; i++)
        {
            powered *= 9;
        }
        return powered;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger result = 0;
        var currentBit = new StringBuilder();
        var numbers = new List<int>();
        int countOfNumbers = 0;

        for (int i = 0; i < input.Length; i++)
        {
            currentBit.Append(input[i]);

            int currentNumber = ConvertTheNumbers(currentBit.ToString());

            if (currentNumber > -1)
            {
                numbers.Add(currentNumber);
                currentBit.Clear();
            }
            
        }

        numbers.Reverse();

        for (int i = 0; i < numbers.Count; i++)
        {
            result += numbers[i] * Power(i);
        }

        Console.WriteLine(result);
    }
}

