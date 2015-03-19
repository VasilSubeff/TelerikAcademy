using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        var cages = new List<int>();
        //cages.Add(3);
        //cages.Add(2);
        //cages.Add(5);
        //cages.Add(5);
        //cages.Add(4);
        //cages.Add(8);
        //cages.Add(4);
        //cages.Add(9);
        //cages.Add(5);
        //cages.Add(6);
        //cages.Add(3);
        //cages.Add(4);
        
        while (true)
        {
            string input = Console.ReadLine();

            if (input != "END")
            {
                cages.Add(int.Parse(input));
            }
            else
            {
                break;
            }
        }

        
        

        for (int i = 0; i < cages.Count; i++)
        {
            int cycles = i + 1;
            int countOfCages = CalcSumOfTakenCages(cages, cycles);
            if (countOfCages <= cages.Count)
            {
                BigInteger sumOfNextCages = CalcSumOfNextCages(cages, cycles, countOfCages);
                BigInteger productOfNextCages = CalcProductOfNextCages(cages, cycles, countOfCages);
                var newCages = ConcatCages(cages, countOfCages, sumOfNextCages, productOfNextCages, i);
                newCages = RemoveZerosAndOnes(newCages);
                
                //clear the list and fill in the new cages.
                cages = new List<int>();

                for (int j = 0; j < newCages.Length; j++)
                {
                    cages.Add(int.Parse(newCages[j].ToString()));
                } 
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", cages));
    }

    private static StringBuilder RemoveZerosAndOnes(StringBuilder newCages)
    {
        var removedCages = new StringBuilder();

        for (int j = 0; j < newCages.Length; j++)
        {
            if (!newCages[j].Equals('0') && !newCages[j].Equals('1'))
            {
                removedCages.Append(newCages[j]);
            }
        }

        return removedCages;
    }

    private static StringBuilder ConcatCages(List<int> cages, int countOfCages, BigInteger sumOfNextCages, BigInteger productOfNextCages, int i)
    {
        var newCages = new StringBuilder();
        newCages.Append(sumOfNextCages.ToString());
        newCages.Append(productOfNextCages.ToString());
        
        for (int j = countOfCages + i + 1; j < cages.Count; j++)
        {
            newCages.Append(cages[j].ToString());
        }

        return newCages;
    }

    private static BigInteger CalcProductOfNextCages(List<int> cages, int cycles, int countOfCages)
    {
        BigInteger product = 1;
        for (int cage = cycles; cage < countOfCages + cycles; cage++)
        {
            product *= (BigInteger)cages[cage];
        }

        return product;
    }
    private static BigInteger CalcSumOfNextCages(List<int> cages, int cycles, int countOfCages)
    {
        BigInteger sum = 0;
        for (int cage = cycles; cage < countOfCages + cycles; cage++)
        {
            sum += (BigInteger)cages[cage];
        }

        return sum;
    }

    private static int CalcSumOfTakenCages(List<int> cages, int cycles)
    {
        int sum = 0;
        for (int cycle = 0; cycle < cycles; cycle++)
        {
            sum += cages[cycle];
        }

        return sum;
    }
}

