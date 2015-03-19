using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class DecodeAndDecrypt
{
    static void Main()
    {
        //string message = "AAABB";
        //string cypher = "BBBBBBA";

        //var encrypted = Encrypt(message, cypher);
               
        //Console.WriteLine(encrypted);

        //string messageToEncode = "AAAABBAAAACGGG";
        //var encoded = Encode(messageToEncode);
        //Console.WriteLine(encoded.ToString());

        //string messageToDecode = "KKICXDE3P";
        //var decoded = Decode(messageToDecode);
        //Console.WriteLine(decoded.ToString());

        //string messageToDecrypt = @"BKOXHI\EQOGX[YSOFTWARE8";


        //task
        string messageToDecrypt = Console.ReadLine();
        int lenOfCipher = GetLenOfCipher(messageToDecrypt);
        //Console.WriteLine(lenOfCipher);

        messageToDecrypt = messageToDecrypt.Remove(messageToDecrypt.Length - 1);

        var decodedMessage = Decode(messageToDecrypt);
        //Console.WriteLine(decodedMessage);

        string cipher = decodedMessage.Substring(decodedMessage.Length - lenOfCipher, lenOfCipher);
        //Console.WriteLine(cipher);

        decodedMessage = decodedMessage.Remove(decodedMessage.Length - lenOfCipher, lenOfCipher);
        //Console.WriteLine(decodedMessage);

        Console.WriteLine(Encrypt(decodedMessage, cipher));

        


    }

    private static int GetLenOfCipher(string messageToDecrypt)
    {
        int lenOfCipher = 0;
        var digits = new List<char>();

        for (int i = messageToDecrypt.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(messageToDecrypt[i]))
            {
                digits.Add(messageToDecrypt[i]);
            }
            else
            {
                break;
            }
        }

        digits.Reverse();

        foreach (var digit in digits)
        {
            lenOfCipher *= 10;
            lenOfCipher += (int)char.GetNumericValue(digit);
        }
        return lenOfCipher;
    }

    private static string Decode(string messageToDecode)
    {
        var decoded = new StringBuilder();
        var count = 0;

        foreach (var ch in messageToDecode)
        {
            if (char.IsDigit(ch))
            {
                count *= 10;
                count += int.Parse(ch.ToString());
            }
            else
            {
                if (count == 0)
                {
                    decoded.Append(ch);
                }
                else
                {
                    decoded.Append(ch, count);
                    count = 0;
                }
            }
        }
        
        return decoded.ToString();
    }

    private static string Encode(string messageToEncode)
    {
        StringBuilder encoded = new StringBuilder();
        int index = 0;

        while (index < messageToEncode.Length)
        {
            char currentLetter = messageToEncode[index];
            int counter = 0;
            int scanIndex = index;

            while (scanIndex < messageToEncode.Length)
            {
                char nextLetter = messageToEncode[scanIndex];

                if (nextLetter != currentLetter)
                {
                    break;
                }
                counter++;
                scanIndex++;
            }
            index = scanIndex;

            if (counter <= 2)
            {
                encoded.Append(currentLetter, counter);
            }
            else
            {
                encoded.Append(counter);
                encoded.Append(currentLetter);
            }

        }
        return encoded.ToString();
    }

    private static string Encrypt(string message, string cypher)
    {
        int len = Math.Max(message.Length, cypher.Length);
        StringBuilder encrypted = new StringBuilder(message);

        for (int i = 0; i < len; i++)
        {
            char messageLetter = encrypted[i % encrypted.Length];
            char cypherLetter = cypher[i % cypher.Length];

            int messageLetterCode = messageLetter - 'A';
            int cypherLetterCode = cypherLetter - 'A';

            int result = (messageLetterCode ^ cypherLetterCode) + 'A';

            encrypted[i % encrypted.Length] = ((char)result);
        }
        return encrypted.ToString();
    }
}

