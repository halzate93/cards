using System;
using UnityEngine;

namespace Cards
{
	[Serializable]
	public class CardData 
	{
		public int id;
		public string name;
		public string description;
		public int cost;
		public Sprite illustration;
		public CardType type;
		public DeckType specificDeck;
	}
}