using System;

class AlphabetArray
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        Console.WriteLine("The letters of the word {0} are located on positions: ", word);
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write((j + 1) + " ");
                }
            }
        }
        Console.WriteLine();
    }
}

