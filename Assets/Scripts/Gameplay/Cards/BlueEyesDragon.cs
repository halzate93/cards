using Gameplay.Effects;

namespace Gameplay.Cards
{
	public class BlueEyesDragon : Minion
	{
		public override void OnBattleCry ()
		{
			DestroyRandomEnemy ();
		}

		public override void OnDeathRattle ()
		{
			DestroyRandomEnemy ();
		}

		private void DestroyRandomEnemy ()
		{
			DestroyRandomEnemy effect = new DestroyRandomEnemy (casterId);
			BoardManager.Instance.Apply (effect);
		}
	}
}