using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class RunAnimationBehavior : EntityEventListenerBehaviour, IRunningListener
    {
        [Required, SerializeField] private PlayerCharacterAnimator _playerCharacterAnimator;
        
        public override void Register(GameEntity entity) => entity.AddRunningListener(this);
        
        public override void Unregister(GameEntity entity) => entity.RemoveRunningListener(this);

        public void OnRunning(GameEntity entity) => _playerCharacterAnimator.EnterRunningAnimation();

    }
}