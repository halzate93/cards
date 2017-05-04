using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DeckEditor
{
	[RequireComponent (typeof (Button))]
	public class SaveDeckButton : MonoBehaviour 
	{
		[SerializeField]
		private DeckMaker deckMaker;

		private Button button;

		private void Awake ()
		{
			button = GetComponent<Button> ();
			button.onClick.AddListener (SaveDeck);
		}
		
		private void SaveDeck ()
		{
			deckMaker.SaveDeck ();
		}

	}
}