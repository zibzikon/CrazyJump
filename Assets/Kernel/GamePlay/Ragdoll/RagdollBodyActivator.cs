using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBodyActivator : EntityEventListenerBehaviour, IRagdollBodyListener
    {
        [Required, SerializeField] private RagdollBodyBehaviour _ragdollBodyBehaviour;
        
        public override void Register(GameEntity entity)
            => entity.AddRagdollBodyListener(this);
        
        public override void Unregister(GameEntity entity)
            => entity.RemoveRagdollBodyListener(this);

        public void OnRagdollBody(GameEntity entity) => _ragdollBodyBehaviour.EnableRagdollPhysics();

    }
}