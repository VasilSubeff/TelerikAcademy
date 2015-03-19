//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("original.txt"))
        {
            string line = reader.ReadLine();
            int counter = 1;
            bool append = true;

            using (StreamWriter writer = new StreamWriter("result.txt", append))
            {
                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", counter, line);
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

