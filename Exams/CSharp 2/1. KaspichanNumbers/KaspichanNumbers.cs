using System;
using System.Collections.Generic;
using System.Text;

class KaspichanNumbers
{
    private static int Power(int power)
    {
        int powered = 1;

        for (int i = 0; i < power; i++)
        {
            powered *= 256;
        }
        return powered;
    }
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong result = 0;
        int power = 0;
        var kaspichanNumbers = PopulateKaspichanNumbers();
        var output = new List<string>();

        if (number == 0)
        {
            Console.WriteLine("A");
            return;
        }

        while (number > 0)
        {
            int reminder = (int)(number % 256);
            output.Add(kaspichanNumbers[reminder]);
            number /= 256;
            result += (ulong)(reminder * Power(power));
            power++;
        }

        output.Reverse();

        foreach (var outp in output)
        {
            Console.Write(outp);
        }
        

        
    }

    private static string[] PopulateKaspichanNumbers()
    {
        var kaspichanNumbers = new string[256];
        int counter = 0;

        for (char chUp = 'A'; chUp <= 'Z'; chUp++)
        {
            kaspichanNumbers[counter] = chUp.ToString();
            counter++;
        }

        for (char chLow = 'a'; chLow <= 'z'; chLow++)
        {
            for (char chUp = 'A'; chUp <= 'Z'; chUp++)
            {
                kaspichanNumbers[counter] = chLow.ToString() + chUp.ToString();
                counter++;

                if (counter == 256)
                {
                    break;
                }
            }

            if (counter == 256)
            {
                break;
            }
        }
        return kaspichanNumbers;
    }}

