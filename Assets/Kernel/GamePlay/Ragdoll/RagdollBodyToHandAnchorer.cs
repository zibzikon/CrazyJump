using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBodyToHandAnchoringBehavior : EntityEventListenerBehaviour, IAnchoredToHandListener
    {
        [Required, SerializeField] private HingeAnchorRagdollBodyPart _anchorRagdollBodyPart;
    
        public override void Register(GameEntity entity)
            => entity.AddAnchoredToHandListener(this);
                        
        public override void Unregister(GameEntity entity)
            => entity.RemoveAnchoredToHandListener(this);

        public void OnAnchoredToHand(GameEntity entity) => _anchorRagdollBodyPart.EnableAnchor();

    }
}