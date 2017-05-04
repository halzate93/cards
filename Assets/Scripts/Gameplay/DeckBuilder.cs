using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Gameplay
{
    public class DeckBuilder: MonoBehaviour
    {
        [SerializeField]
        private List<Card> deck;
        
        public Deck Build (string id)
        {
            Stack<Card> cards = deck.ToStack ();
            return new Deck (cards);
        }
    }
}