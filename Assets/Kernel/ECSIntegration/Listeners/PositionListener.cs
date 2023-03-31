using UnityEngine;

namespace Kernel.ECS.Listeners
{
    public class PositionListener : MonoBehaviour, IGameEventListener, IPositionListener
    {
        public void Register(GameEntity entity)
        {
            entity.AddPositionListener(this);
        }

        public void Unregister(GameEntity entity)
        {
            entity.RemovePositionListener(this);
        }

        public void OnPosition(GameEntity entity, Vector3 value)
        {
            transform.position = value;
        }
    }
}