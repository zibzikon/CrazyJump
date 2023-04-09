using UnityEngine;

namespace Kernel.ECSIntegration
{
    public abstract class EntityEventListenerBehaviour : MonoBehaviour, IGameEventListener
    {
        public abstract void Register(GameEntity entity);
        
        public abstract void Unregister(GameEntity entity);
    }
}