using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class FlyingAnimationBehaviour: EntityEventListenerBehaviour, IMakingJumpListener
    {
        [Required, SerializeField] private PlayerCharacterAnimator _playerCharacterAnimator;
        
        public override void Register(GameEntity entity) => entity.AddMakingJumpListener(this);
        
        public override void Unregister(GameEntity entity) => entity.RemoveMakingJumpListener(this);

        public void OnMakingJump(GameEntity entity) => _playerCharacterAnimator.EnterFlyingAnimation();

    }
}