using System;
using Kernel.ECS;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.Collision
{
    public class TriggerBehavior : EntityBehaviour
    {
        [SerializeField] private LayerMask _triggeringLayers;
        
        private void OnTriggerEnter(Collider other)
        {
            if(!TryGetEntity(other, out var collidedEntity) || Entity.hasCollidedEntityID) return;

            Entity.AddCollidedEntityID(collidedEntity.iD.Value);
        }

        private void OnTriggerExit(Collider other)
        {
            if(!TryGetEntity(other, out var collidedEntity) || !Entity.hasCollidedEntityID) return;

            if (Entity.collidedEntityID.Value != collidedEntity.iD.Value) throw new InvalidOperationException();
            
            Entity.RemoveCollidedEntityID();
        }

        private bool TryGetEntity(Collider other, out GameEntity entity)
        {
            entity = null;
            if(!other.TryGetComponent(out EntityCollider collider) ||
               !collider.SatisfiesLayerMask(_triggeringLayers)) return false;

            entity = collider.Entity;
            return true;
        }
        
    }
}