//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string filePathOne = "file1.txt";
        string filePathTwo = "file2.txt";

        using (StreamWriter writer = new StreamWriter("result.txt"))
        {
            writer.Write(ReadText(filePathOne) + ReadText(filePathTwo));
        }     
    }

    private static string ReadText(string filePath)
    {
        string text;

        using (StreamReader file = new StreamReader(filePath))
        {
            text = file.ReadToEnd();
        }

        return text;
    }
}

