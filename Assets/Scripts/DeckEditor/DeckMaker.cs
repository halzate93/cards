using System;
using Cards;
using UnityEngine;
using Utils;

namespace DeckEditor
{
    public class DeckMaker: MonoBehaviour
    {
        private const string storageKey = "user_deck";
        private DeckData currentDeck;

        private void Start ()
        {
            currentDeck = LocalStorage.GetData<DeckData> (storageKey);
            if (currentDeck == null)
                currentDeck = DeckData.BuildEmpty ();
        }

        public void SaveDeck ()
        {
            LocalStorage.SetData<DeckData> (storageKey, currentDeck);
        }

        public void AddCard (CardData card)
        {
            currentDeck.cardIds.Add (card.id);
        }

        public void SetType(DeckType deckType)
        {
            currentDeck.type = deckType;
        }
    }
}