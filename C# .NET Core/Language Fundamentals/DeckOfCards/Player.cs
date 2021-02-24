using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        private string Name;
        private List <Card> hand;
        public Player(string name)
        {
            Name = name;
            hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card card = deck.Deal();
            hand.Add(card);
            return card;
        }

        public Card Discard(int index)
        {
            Card card;
            if(index < hand.Count)
            {
                card = hand[index];
                hand.RemoveAt(index);
                return card;
            }
            else return null;
        }      
    }
}
