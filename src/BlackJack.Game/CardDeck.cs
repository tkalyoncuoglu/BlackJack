using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class CardDeck
    {
        private List<Card> initialDeck;

        private List<Card> cards = new List<Card>();

        private static Random rnd = new Random(Environment.TickCount);

        private List<Card> Create_52_deck()  
        {
            var k = Enumerable.Range(2, Card.GetMaxPictureNumber() - 1).ToList();

            var deck = k.Select(x => new Card(x, (Card.CardColor)((x - 2) % 4))).ToList();

            return deck;
        }

        public CardDeck() 
        {
            initialDeck = Create_52_deck();
        }

        public bool IsEmpty() 
        {
            return cards.Count == 0;
        }

        public bool HasCards()
        {
            return !IsEmpty();
        }

        public int CardCount() 
        {
            return cards.Count;
        } 

        public void Shuffle(int cardCount)
        {
            var indices = Enumerable.Range(1, cardCount).Select(x => rnd.Next(0, initialDeck.Count - 1)).ToList();

            cards = indices.Select(x => initialDeck[x]).ToList();

            indices.ForEach(x => initialDeck.RemoveAt(x));
        }

        public Card PickCard() 
        {
            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

       
    }

   
}