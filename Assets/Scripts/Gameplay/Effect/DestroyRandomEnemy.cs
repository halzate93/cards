

namespace Gameplay.Effects
{
    public class DestroyRandomEnemy : IEffect
    {
        private int casterId;

        public DestroyRandomEnemy (int casterId)
        {
            this.casterId = casterId;
        }

        public void Apply()
        {
            Minion toDestroy = BoardManager.Instance.GetRandomEnemy (casterId);
            if (toDestroy != null)
                toDestroy.Destroy ();
        }
    }
}