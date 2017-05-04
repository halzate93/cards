
namespace Gameplay
{
	public abstract class Spell: Card
	{
		public override void OnPlay ()
		{
			BoardManager.Instance.Cast (this);
		}

		public abstract void OnCast ();
	}
}
