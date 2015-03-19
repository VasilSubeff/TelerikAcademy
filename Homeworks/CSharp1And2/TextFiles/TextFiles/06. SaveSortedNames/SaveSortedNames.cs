//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();

        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
        }

        names.Sort();

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
    }
}

