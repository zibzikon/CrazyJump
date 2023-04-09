using System;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.GamePlay.Collision
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