using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
	public class BoardManager : MonoBehaviour
	{
        [SerializeField]
		private Player[] players;
		private int current;

		private Stack<IEffect> resolveStack;

        public static BoardManager Instance 
		{ 
			get; private set; 
		}

		private Player Current
		{
			get
			{
				return players[current];
			}
		}

		public int CurrentId
		{
			get
			{
				return current;
			}
		}

		private void Awake ()
		{
			Instance = this;
			resolveStack = new Stack<IEffect> ();
		}

		private void Start ()
		{
			Current.OnTurn ();
		}

		public void Apply (IEffect effect)
		{
			resolveStack.Push (effect);
			Clear ();
		}

		private void Clear ()
		{
			if (resolveStack.Count == 0) return;
			IEffect next = resolveStack.Pop ();
			next.Apply ();
		}

		public void Summon(Minion minion)
        {
            Current.Board.Summon (minion);
			minion.OnBattleCry ();
        }

		public void Cast (Spell spell)
		{
			spell.OnCast ();
		}

		public Minion GetRandomEnemy (int casterId)
		{
			Board board = players[1 - casterId].Board;
			return board.GetRandomMinion ();
		}
	}
}