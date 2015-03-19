//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        string input = "I want to encode";
        string cipher = "key";

        string encoded = EncodeOrDecode(input, cipher);
        Console.WriteLine(encoded);

        string decoded = EncodeOrDecode(encoded, cipher);
        Console.WriteLine(decoded);
    }

    private static string EncodeOrDecode(string input, string cipher)
    {
        int cipherLength = cipher.Length;
        int startIndex = 0;
        string partOfTheString = "";
        int differenceInLength = input.Length % cipherLength;
        StringBuilder encoded = new StringBuilder();

        while (startIndex < input.Length - differenceInLength)
        {
            partOfTheString = input.Substring(startIndex, cipherLength);

            for (int i = 0; i < cipherLength; i++)
            {
                encoded.Append((char)(partOfTheString[i] ^ cipher[i]));
            }

            startIndex += partOfTheString.Length;
        }

        if (differenceInLength > 0)
        {
            for (int i = 0; i < differenceInLength; i++)
            {
                encoded.Append((char)(input[(input.Length - differenceInLength) + i] ^ cipher[i]));
            }
        }
        
        return encoded.ToString();
    }
}

