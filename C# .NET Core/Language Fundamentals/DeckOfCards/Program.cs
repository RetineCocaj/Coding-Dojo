using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card("Diamonds", 1);
            Deck deck = new Deck();
            deck.Shuffle();
            deck.ShowDeck();
            Player player1 = new Player("Retina");
            player1.Draw(deck);
        }
    }
}
