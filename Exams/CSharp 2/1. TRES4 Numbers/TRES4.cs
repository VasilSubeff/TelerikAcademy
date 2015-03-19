using System;
using System.Text;
using System.Collections.Generic;
class TRES4
{
    static void Main()
    {
        ulong decNumber = ulong.Parse(Console.ReadLine());
        string tres4 = string.Empty;

        var reversed = new List<string>();
        if (decNumber == 0)
        {
            
        }

        do
        {
            int bit = (int)(decNumber % 9);
            decNumber /= 9;

            reversed.Add(GetValue(bit));
        }
        while (decNumber > 0);

        reversed.Reverse();

        foreach (var item in reversed)
        {
            tres4 += item;
        }

        Console.WriteLine(tres4);
    }

    private static string GetValue(int bit)
    {
        switch (bit)
        {
            case 0: return "LON+";
            case 1: return "VK-";
            case 2: return "*ACAD";
            case 3: return "^MIM";
            case 4: return "ERIK|";
            case 5: return "SEY&";
            case 6: return "EMY>>";
            case 7: return "/TEL";
            case 8: return "<<DON";
            default:
                throw new ArgumentException("Invalid input in GetValue() Method !");
        }
    }
}

