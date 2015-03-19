using System;

class Multiverse
{
    static void Main()
    {
        string input = Console.ReadLine();
        string bit = string.Empty;
        long result = 0;
        int position = input.Length / 3 - 1;

        for (int i = 0; i < input.Length; i += 3)
        {
            bit = input.Substring(i, 3);
            result += ConvertTheNumber(bit) * Power(position);
            position--;
        }

        Console.WriteLine(result);
    }

    private static long Power(int power)
    {
        long powered = 1;

        for (int i = 0; i < power; i++)
        {
            powered *= 13;
        }
        return powered;
    }
    private static int ConvertTheNumber(string bit)
    {
        switch (bit)
        {
            case "CHU": return 0;
            case "TEL": return 1;
            case "OFT": return 2;
            case "IVA": return 3;
            case "EMY": return 4;
            case "VNB": return 5;
            case "POQ": return 6;
            case "ERI": return 7;
            case "CAD": return 8;
            case "K-A": return 9;
            case "IIA": return 10;
            case "YLO": return 11;
            case "PLA": return 12;
            default:
                throw new ArgumentException("Invalid bit input");

        }
    }
}

