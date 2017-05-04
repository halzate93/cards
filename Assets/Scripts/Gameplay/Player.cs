using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
	public class Player : MonoBehaviour 
	{
		[SerializeField]
		private Board board;
		[SerializeField]
		private DeckBuilder builder;
		private Deck deck;
		[SerializeField]
		private List<Card> hand;

		public Board Board
		{
			get
			{
				return board;
			}
		}

		private void Awake ()
		{
			deck = builder.Build ("");
			hand = new List<Card> (10);
		}

		public void OnTurn ()
		{
			DrawCard ();
		}

		public void DrawCard ()
		{
			Add (deck.GetNext ());
		}

		private void Play (Card card)
		{
			card.OnPlay ();
			hand.Remove (card);
		}

		private void Add (Card prefab)
		{
			Card card = Instantiate (prefab);
			card.OnSelected += Play;
			hand.Add (card);
		}
	}
}