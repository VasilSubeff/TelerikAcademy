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

        //long[] cells = {4, 17, 4, 2, 7, 11, 3, 2};

        BigInteger mollyFlowers = cells[0];
        BigInteger dollyFlowers = cells[cells.Length - 1];

        BigInteger mollyStartCell = 0;
        BigInteger dollyStartCell = cells.Length - 1;

        bool mollyWins = false;
        bool dollyWins = false;

        while (true)
        {
            bool isSplit = true;

            BigInteger mollyCurrentCell = mollyStartCell;
            BigInteger dollyCurrentCell = dollyStartCell;

            //flowers on cell
            BigInteger mollyFlowersInCell = cells[(int)mollyCurrentCell];
            BigInteger dollyFlowersInCell = cells[(int)dollyCurrentCell];

            //collects the flowers before moving 
            if (isSplit)
            {
                cells[(int)mollyStartCell] = 0;
                cells[(int)dollyStartCell] = 0;
            }
            else
            {
                cells[(int)mollyStartCell] = 1;
                cells[(int)dollyStartCell] = 1;
            }


            //move
            mollyCurrentCell = (mollyCurrentCell + mollyFlowersInCell) % cells.Length;
            dollyCurrentCell = (((dollyCurrentCell - dollyFlowersInCell) % cells.Length) + cells.Length) % cells.Length;

            //get the flowers
            if (mollyCurrentCell == dollyCurrentCell)
            {
                if (cells[(int)mollyCurrentCell] % 2 == 0)
                {
                    isSplit = true;
                }
                else
                {
                    isSplit = false;
                }

                mollyFlowers += cells[(int)mollyCurrentCell] / 2;
                dollyFlowers += cells[(int)dollyCurrentCell] / 2;
            }
            else
            {
                if (cells[(int)mollyCurrentCell] > 0 && cells[(int)dollyCurrentCell] > 0)
                {
                    mollyFlowers += cells[(int)mollyCurrentCell];
                    dollyFlowers += cells[(int)dollyCurrentCell];
                }
            }

            if (cells[(int)mollyCurrentCell] == 0 && cells[(int)dollyCurrentCell] == 0)
            {
                dollyWins = true;
                mollyWins = true;
                break;
            }
            else if (cells[(int)mollyCurrentCell] == 0)
            {
                dollyFlowers += cells[(int)dollyCurrentCell];
                dollyWins = true;
                break;
            }
            else if (cells[(int)dollyCurrentCell] == 0)
            {
                mollyFlowers += cells[(int)mollyCurrentCell];
                mollyWins = true;
                break;
            }

            mollyStartCell = mollyCurrentCell;
            dollyStartCell = dollyCurrentCell;
        }

        if ((mollyWins && dollyWins) || mollyFlowers == dollyFlowers)
        {
            Console.WriteLine("Draw");
        }
        else if (dollyWins)
        {
            Console.WriteLine("Dolly");
        }
        else if (mollyWins)
        {
            Console.WriteLine("Molly");
        }

        Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
    }
}