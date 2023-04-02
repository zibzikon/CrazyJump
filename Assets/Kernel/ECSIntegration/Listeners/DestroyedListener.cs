using UnityEngine;

namespace Kernel.ECS.Listeners
{
    public class DestroyedListener : MonoBehaviour, IGameEventListener, IDestroyedListener
    {
        public void Register(GameEntity entity)
            => entity.AddDestroyedListener(this);

        public void Unregister(GameEntity entity)
            => entity.RemoveDestroyedListener(this);

        public void OnDestroyed(GameEntity entity)
        {
            Destroy(gameObject);
        }
    }
}