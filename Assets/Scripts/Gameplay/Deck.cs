using System.Collections.Generic;

namespace Gameplay
{
    public class Deck
    {
        private Stack<Card> cards;

        public Deck (Stack<Card> cards)
        {
            this.cards = cards;
        }

        public Card GetNext ()
        {
            return cards.Pop ();
        }
    }
}