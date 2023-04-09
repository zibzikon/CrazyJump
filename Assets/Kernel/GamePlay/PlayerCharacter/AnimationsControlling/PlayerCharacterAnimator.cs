using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class PlayerCharacterAnimator : MonoBehaviour
    {
        [Required, SerializeField]private Animator _animator;
        
        [SerializeField] private string _idleAnimationKey;
        [SerializeField] private string _runningAnimationKey;
        [SerializeField] private string _flyingAnimationKey;
        [SerializeField] private string _hookingAnimationKey;
        

        private string _lastEnteredAnimationKey;
        
        [HideInEditorMode, Button] public void EnterIdleAnimation() => EnterAnimation(_idleAnimationKey);

        [HideInEditorMode, Button] public void EnterRunningAnimation() => EnterAnimation(_runningAnimationKey);

        [HideInEditorMode, Button] public void EnterFlyingAnimation() => EnterAnimation(_flyingAnimationKey);

        [HideInEditorMode, Button] public void EnterHookingAnimation() => EnterAnimation(_hookingAnimationKey);

        private void EnterAnimation(string key)
        {
            if(!string.IsNullOrEmpty(_lastEnteredAnimationKey))
                _animator.SetBool(key, false);
            
            _lastEnteredAnimationKey = key;
            _animator.SetBool(key, true);
        }
    }
}