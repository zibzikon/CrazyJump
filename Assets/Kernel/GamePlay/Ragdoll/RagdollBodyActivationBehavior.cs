using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBodyActivationBehavior : EntityEventListenerBehaviour, IRagdollBodyListener
    {
        [FormerlySerializedAs("_ragdollBodyBehaviour")] [Required, SerializeField] private RagdollBody ragdollBody;
        
        public override void Register(GameEntity entity)
            => entity.AddRagdollBodyListener(this);
        
        public override void Unregister(GameEntity entity)
            => entity.RemoveRagdollBodyListener(this);

        public void OnRagdollBody(GameEntity entity) => ragdollBody.EnableRagdollPhysics();

    }
}