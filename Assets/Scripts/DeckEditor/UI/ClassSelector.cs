using System.Collections;
using System.Collections.Generic;
using Cards;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace DeckEditor
{
	[RequireComponent (typeof (Dropdown))]
	public class ClassSelector : MonoBehaviour 
	{
		[SerializeField]
		private DeckMaker deckMaker;
		private Dropdown dropdown;

		private void Awake ()
		{
			dropdown = GetComponent<Dropdown> ();
		}

		private void Start () 
		{
			dropdown.SetOptions<DeckType> ();	
			dropdown.onValueChanged.AddListener (SetDeckType);
		}

		private void SetDeckType (int value)
		{
			deckMaker.SetType (dropdown.GetValue<DeckType> ());
		}
	}
}