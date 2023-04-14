using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.ValuePanel.Animation
{
    public class ValuePanelDisappearingAnimationBehaviour : EntityEventListenerBehaviour, IDisappearingStartedListener
    {
        [Required, SerializeField] private ValuePanelAnimator _valuePanelAnimator;
        public override void Register(GameEntity entity) => entity.AddDisappearingStartedListener(this);

        public override void Unregister(GameEntity entity) => entity.RemoveDisappearingStartedListener(this);

        public void OnDisappearingStarted(GameEntity entity) => _valuePanelAnimator.EnterDisappearingAnimation();
        
    }
}