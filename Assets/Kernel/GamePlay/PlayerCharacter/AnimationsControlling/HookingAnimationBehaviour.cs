using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class HookingAnimationBehaviour : EntityEventListenerBehaviour , IHookingStartedListener
    {
        [Required, SerializeField] private PlayerCharacterAnimator _playerCharacterAnimator;
                
        public override void Register(GameEntity entity) => entity.AddHookingStartedListener(this);

        public override void Unregister(GameEntity entity) => entity.RemoveHookingStartedListener(this);

        public void OnHookingStarted(GameEntity entity) => _playerCharacterAnimator.EnterHookingAnimation();
    }
}