using Kernel.ECSIntegration;
using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class AnimationClipLengthBasedHookingProcessDurationRegister : EntityRegisterBehaviour
    {
        [Required, SerializeField] private Animator _animator;
        [SerializeField] private string _animationClipName;
        
        public override void Register(GameEntity entity)
        {
            var length = _animator.GetAnimationClipLenght(_animationClipName);
            entity.AddHookingProcessDuration(length);
        }
    }
}