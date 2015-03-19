//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintaDeckof52Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] suits = { "spades", "clubs", "hearts", "diamonds" };
        char[] suits = { '\x03', '\x04', '\x05', '\x06' };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                if (j < suits.Length - 1)
                {
                    Console.Write("{0} of {1}, ", cards[i], suits[j]);
                }
                else
                {
                    Console.Write("{0} of {1}", cards[i], suits[j]);
                }
                
            }
            Console.WriteLine();
        }
    }
}

