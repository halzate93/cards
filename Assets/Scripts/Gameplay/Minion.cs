using System;

namespace Gameplay
{
	public class Minion : Card 
	{
		public event Action<Minion> OnDestroy; 
		public int lifepoints;
		public int attackPoints;
		public int casterId;

		public override void OnPlay()
        {
			BoardManager.Instance.Summon (this);
        }

		public virtual void OnBattleCry ()
		{

		}

		public virtual void OnDeathRattle ()
		{

		}

		public void Attack (Minion enemy)
		{
			enemy.ApplyDamage (attackPoints);
		}

		public void ApplyDamage (int damagePoints)
		{
			lifepoints -= damagePoints;
		}

		public void CheckForDeath ()
		{
			if (lifepoints <= 0)
				Destroy ();
		}

		public void Destroy ()
		{
			if (OnDestroy != null)
				OnDestroy (this);
			Destroy (gameObject);
			OnDeathRattle ();
		}
    }
}