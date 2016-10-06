using UnityEngine;
using System.Collections.Generic;


namespace openl5r.Basic
{
    public class Deck
    {
        protected List<Card> cards;

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
        }

        /// <summary>
        /// Shuffle all cards in this Deck
        /// </summary>
        virtual public void Shuffle()
        {
            for(int i = 0; i < cards.Count; i++)
            {
                int pos = Random.Range(0, cards.Count);
                Card temp = cards[pos];
                cards[pos] = cards[i];
                cards[i] = temp;
            }
        }

        /// <summary>
        /// Draw a Card from the Deck
        /// </summary>
        /// <returns>A Card from the deck</returns>
        virtual public Card Draw()
        {
            return Draw(1)[0];
        }
        /// <summary>
        /// Draw a ammount of Cards from the Deck
        /// </summary>
        /// <param name="quantity">How many cards should be drawn from Deck, if greater then 
        /// ammount of remaing Cards in Deck it will return all Cards in Deck instead</param>
        /// <returns>A List of Cards</returns>
        virtual public List<Card> Draw(int quantity)
        {
            List<Card> cardsResult = new List<Card>();
            if(cards.Count < quantity)
            {
                quantity = cards.Count;
            }
            for (int i =0; i< quantity; i++)
            {
                cardsResult.Add(cards[0]);
                cards.RemoveAt(0);
            }
            return cardsResult;
        }
    }
}