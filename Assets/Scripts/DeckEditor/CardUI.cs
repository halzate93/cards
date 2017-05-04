using System;
using Cards;
using UnityEngine;
using UnityEngine.UI;

namespace DeckEditor
{
	[RequireComponent (typeof (Button))]
	public class CardUI : MonoBehaviour 
	{
		public event Action<CardData> OnCardAdd;

		[SerializeField]
		private Image illustration;
		private CardData data;
		private Button button;

		private void Awake ()
		{
			button = GetComponent<Button> ();
			button.onClick.AddListener (AddCard);
		}

		public void SetData (CardData data)
		{
			this.data = data;
			illustration.sprite = data.illustration;
		}

		private void AddCard ()
		{
			if (OnCardAdd != null)
				OnCardAdd (data);
		}
	}
}