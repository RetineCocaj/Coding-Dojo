using System.Collections.Generic;
using System;
namespace DeckOfCards
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            Reset();
        }

        public List<Card> Reset()
        {
            cards.Clear();
            for(int i = 0; i < 4; i++)
            {
                int j = 1;
                while(j < 14)
                {
                    cards.Add(new Card(Card.Suits[i], j));
                    j++;
                }
            }
            return cards;
        }

        public List<Card> Cards
        {
            get { return this.cards; }
        }

        public void ShowDeck()
        {
            foreach (Card c in cards)
            {
                c.SayCard();
            }
        }

        public Card Deal()
        {
            Card theCard = cards[0];
            cards.RemoveAt(0);
            return theCard;
        }

        public void Shuffle()
        {
            List<Card> cardsToShuffle = this.cards;
            List<Card> shuffled = new List<Card>();
            Random randy = new Random();
            while(cardsToShuffle.Count > 0)
            {
                int idx = randy.Next(0, cardsToShuffle.Count);
                shuffled.Add(cardsToShuffle[idx]);
                cardsToShuffle.RemoveAt(idx);
            }
            this.cards = shuffled;
        }
    }

}