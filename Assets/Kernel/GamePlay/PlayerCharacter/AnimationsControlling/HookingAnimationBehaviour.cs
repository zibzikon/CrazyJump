using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class HookingAnimationBehaviour : EntityEventListenerBehaviour , IHookingAnimationStartedListener
    {
        [Required, SerializeField] private PlayerCharacterAnimator _playerCharacterAnimator;
                
        public override void Register(GameEntity entity) => entity.AddHookingAnimationStartedListener(this);
                
        public override void Unregister(GameEntity entity) => entity.RemoveHookingAnimationStartedListener(this);

        public void OnHookingAnimationStarted(GameEntity entity) => _playerCharacterAnimator.EnterHookingAnimation();
    }
}