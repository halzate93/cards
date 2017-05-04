using System;
using System.Collections.Generic;

namespace Cards
{
	[Serializable]
	public class DeckData
	{
		private const int defaultSize = 30;

		public string name;
		public DeckType type;
		public List<int> cardIds;

		public static DeckData BuildEmpty ()
		{
			DeckData deck = new DeckData ();
			deck.name = "";
			deck.type = DeckType.None;
			deck.cardIds = new List<int> (defaultSize);
			return deck;
		}
	}
}