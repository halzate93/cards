using Cards;
using UnityEngine;
using UnityEngine.UI;

namespace DeckEditor
{
    [RequireComponent (typeof (GridLayoutGroup))]
    public class CardBookUI: MonoBehaviour
    {
        [SerializeField]
        private DeckMaker deckMaker;
        [SerializeField]
        private CardBook cardbook;
        [SerializeField]
        private CardUI prefab;

        private void Start ()
        {
            InstantiateCards ();
        }

        private void InstantiateCards ()
        {
            for (int i = 0; i < cardbook.cards.Length; i++)
                AddCard (cardbook.cards[i]);
        }

        private void AddCard (CardData data)
        {
            CardUI card = Instantiate (prefab, transform);
            card.OnCardAdd += AddCardToDeck; 
            card.SetData (data);
        }

        private void AddCardToDeck (CardData card)
        {
            deckMaker.AddCard (card);
        }
    }
}