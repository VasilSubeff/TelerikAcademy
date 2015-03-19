using System;
using System.Text;

class StrangeLandNumbers
{
    static void Main()
    {

        string input = Console.ReadLine();
        //string input = "bINoBJECpNWEhT";
        long decBit = 0;
        int power = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            
            var builder = new StringBuilder();

            for (int j = i; j >= 0; j--)
            {
                if (char.IsUpper(input[j]))
                {
                    builder.Append(input[j].ToString());
                }
                else
                {
                    builder.Append(input[j].ToString());
                    string bit = ReverseString(builder.ToString());
                    int decRep = ConvertNumbers(bit);
                    decBit += decRep * Power(power);
                    power++;
                    i = j;
                    break;
                }
            }
        }

        Console.WriteLine(decBit);


        //ConvertNumbers();
    }

    private static long Power(int power)
    {
        long powered = 1;

        for (int i = 0; i < power; i++)
        {
            powered *= 7;
        }
        return powered;
    }

    private static int ConvertNumbers(string bit)
    {
        switch (bit)
        {
            case "f": return 0;
            case "bIN": return 1;
            case "oBJEC": return 2;
            case "mNTRAVL": return 3;
            case "lPVKNQ": return 4;
            case "pNWE": return 5;
            case "hT": return 6;
            default:
                throw new ArgumentException("Invalid bit !");
        }
    }
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }


}

