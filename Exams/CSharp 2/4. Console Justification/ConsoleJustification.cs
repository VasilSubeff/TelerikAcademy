using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int symbolsOnARow = int.Parse(Console.ReadLine());
        var words = new Queue<string>();
        string space = " ";

        for (int i = 0; i < numberOfLines; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < line.Length; j++)
            {
                words.Enqueue(line[j]);
            }
        }

        while (words.Any())
        {
            var row = new StringBuilder();

            while (row.Length + words.Peek().Length <= symbolsOnARow)
            {
                row.Append(words.Dequeue());
                row.Append(space);

                if (!words.Any())
                {
                    break;
                }
            }

            if (row[row.Length - 1] == ' ')
            {
                row.Remove(row.Length - 1, 1);
            }

            if (row.ToString().IndexOf(space) > -1)
            {
                int spaceIndex = 0;
                int spaceIteration = 1;

                while (row.Length < symbolsOnARow)
                {
                    spaceIndex = row.ToString().IndexOf(space, spaceIndex, StringComparison.InvariantCultureIgnoreCase);

                    if (spaceIndex > -1)
                    {
                        row.Insert(spaceIndex + spaceIteration, space);
                        spaceIndex += spaceIteration + 1;
                    }
                    else
                    {
                        spaceIndex = 0;
                        spaceIteration++;
                    }
                }
            }
            Console.WriteLine(row);
        }
    }
}

