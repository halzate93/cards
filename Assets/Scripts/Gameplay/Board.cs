using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
	public class Board : MonoBehaviour
	{
		[SerializeField]
		private List<Minion> minions;
		[SerializeField]
		private int id;

		private void Start ()
		{
			foreach (Minion inScene in minions)
			{
				inScene.OnDestroy += RemoveMinion;
				inScene.casterId = id;
			}
		}

		public void Summon (Minion minion)
		{
			minion.OnDestroy += RemoveMinion;
			minions.Add (minion);
			minion.casterId = id;
			UpdatePosition (minion);
		}

		public Minion GetRandomMinion ()
		{
			if (minions.Count == 0) return null;
			int index = Random.Range (0, minions.Count);
			return minions[index];
		}

		private void UpdatePosition (Minion minion)
		{
			minion.transform.SetParent (transform);
			Vector2 position = minion.transform.localPosition;
			position.y = 0f;
			minion.transform.localPosition = position;
		}

		private void RemoveMinion (Minion minion)
		{
			minion.OnDestroy -= RemoveMinion;
			minions.Remove (minion);
		}
	}
}