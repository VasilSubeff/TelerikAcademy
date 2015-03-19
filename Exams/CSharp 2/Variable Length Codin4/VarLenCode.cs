using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] sequence = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();
        int numberOfLines = int.Parse(Console.ReadLine());
        var codeTable = new Dictionary<int, string>();
        

        for (int i = 0; i < numberOfLines; i++)
        {
            string input = Console.ReadLine();
            int codeTableIndex = int.Parse(input.Substring(1, input.Length - 1));
            codeTable.Add(codeTableIndex, input[0].ToString());
            
        }

        var binary = new StringBuilder();

        foreach (var element in sequence)
        {
            binary.Append(Convert.ToString(element, 2).PadLeft(8, '0'));
        }

        var text = new StringBuilder();
        

        for (int i = 0; i < binary.Length - 1; i++)
        {
            int counter = 0;

            for (int j = i; j < binary.Length; j++)
            {
                if (binary[i] == binary[j] && binary[i].ToString() == "1") 
                {
                    counter++;
                }
                else
                {
                    break;
                }

                if (counter > 1)
                {
                    i = j;
                }
            }

            if (counter > 0)
            {
                text.Append(codeTable[counter]);
            }
        }

        Console.WriteLine(text.ToString());
    }
}

