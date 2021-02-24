using System;

namespace DeckOfCards
{
    class Card
    {
        private string StringVal;
        private string Suit;
        private int Value;
        public static string[] Suits = new string[4]{"Spades", "Hearts", "Diamonds", "Clubs"};
        public Card(string suit, int val)
        {
            switch (val)
            {
                case 11: 
                    StringVal = "Jack";
                    break;
                case 12: 
                    StringVal = "Queen";
                    break;
                case 13: 
                    StringVal = "King";
                    break;
                case 1: 
                    StringVal = "Ace";
                    break;
                default:
                    StringVal = val.ToString();
                    break;
            }
            Suit = suit;
            Value = val;
        }
        public void SayCard()
        {
            System.Console.WriteLine("The {0} of {1}", StringVal, Suit);
        }
    }
}
