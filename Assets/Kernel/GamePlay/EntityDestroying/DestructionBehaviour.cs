using UnityEngine;

namespace Kernel.ECSIntegration.Listeners
{
    public class DestructionBehaviour : MonoBehaviour, IGameEventListener, IDestructedListener
    {
        public void Register(GameEntity entity) => entity.AddDestructedListener(this);

        public void Unregister(GameEntity entity) => entity.RemoveDestructedListener(this);

        public void OnDestructed(GameEntity entity) => Destroy(gameObject);
    }
}