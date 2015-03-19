using System;
using System.Linq;
using System.Numerics;
class TwoGOneP
{
    static void Main()
    {
        BigInteger[] cells = Console.ReadLine()
                             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(x => BigInteger.Parse(x))
                             .ToArray();

        int mollyIndex = 0;
        int dollyIndex = 0;

        BigInteger mollyTotalFlowers = 0;
        BigInteger dollyTotalFlowers = 0;

        string winner = string.Empty;

        while (true)
        {
            if (cells[mollyIndex] == 0 || cells[dollyIndex] == 0)
            {
                if (cells[mollyIndex] == 0 && cells[dollyIndex] == 0)
                {
                    winner = "Draw";
                }
                else if (cells[mollyIndex] == 0)
                {
                    winner = "Dolly";
                }
                else if (cells[dollyIndex] == 0)
                {
                    winner = "Molly";
                }


                mollyTotalFlowers += cells[mollyIndex];
                dollyTotalFlowers += cells[dollyIndex];
                break;
            }

            BigInteger currentMolyFlowers = cells[mollyIndex];
            BigInteger currentDollyFlowers = cells[dollyIndex];

            if (mollyIndex == dollyIndex)
            {
                cells[mollyIndex] = currentMolyFlowers % 2;
                mollyTotalFlowers += currentMolyFlowers / 2;
                dollyTotalFlowers += currentDollyFlowers /2 ;
            }
            else
            {
                cells[mollyIndex] = 0;
                cells[dollyIndex] = 0;

                mollyTotalFlowers += currentMolyFlowers;
                dollyTotalFlowers += currentDollyFlowers;
            }

            mollyIndex = (int)((mollyIndex + currentMolyFlowers) % cells.Length);
            dollyIndex = (int)((dollyIndex - currentDollyFlowers) % cells.Length);
            if (dollyIndex < 0)
            {
                dollyIndex += cells.Length;
            }
        }
        Console.WriteLine(winner);
        Console.WriteLine(mollyTotalFlowers + " " + dollyTotalFlowers);

    }
}