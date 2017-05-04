using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay
{
    public abstract class Card: MonoBehaviour, IPointerClickHandler
    {
        public event Action<Card> OnSelected;

        public abstract void OnPlay ();

        public void OnPointerClick(PointerEventData eventData)
        {
            if (OnSelected != null)
                OnSelected (this);
        }
    }
}