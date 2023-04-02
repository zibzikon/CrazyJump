using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay.Collision
{
    [RequireComponent(typeof(Collider))]
    public class EntityCollider : EntityBehaviour, IGameEntityRegister
    {
        public Collider Collider { get; private set; }

        protected override void OnAwake()
        {
            Collider = GetComponent<Collider>();
        }
        
        public void Register(GameEntity entity)
        {
            entity.isCollisionable = true;
        }
    }
}