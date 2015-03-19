//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckforaPlayCard
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        Console.WriteLine("Enter a card: ");
        string inputCard = Console.ReadLine().ToUpper();
        string validCard = "no";
        for (int i = 0; i < cards.Length; i++)
        {
            if (inputCard == cards[i])
            {
                validCard = "yes";
            }
        }
        Console.WriteLine(validCard);
    }
}

