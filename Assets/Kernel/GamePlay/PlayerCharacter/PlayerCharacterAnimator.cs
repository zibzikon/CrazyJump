using Kernel.Extensions;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    [RequireComponent(typeof(Animator))]
    public class PlayerCharacterAnimator : MonoBehaviour
    {
        [SerializeField] private string _idleAnimationKey;
        [SerializeField] private string _runningAnimationKey;
        [SerializeField] private string _flyingAnimationKey;
        [SerializeField] private string _hookingAnimationKey;
        
        private Animator _animator;

        private string _lastEnteredAnimationKey;

        private void Awake() => _animator = GetComponent<Animator>().ThrowIfNull();

        public void EnterIdleAnimation() => EnterAnimation(_idleAnimationKey);

        public void EnterRunningAnimation() => EnterAnimation(_runningAnimationKey);

        public void EnterFlyingAnimation() => EnterAnimation(_flyingAnimationKey);

        public void EnterHookingAnimation() => EnterAnimation(_hookingAnimationKey);

        private void EnterAnimation(string key)
        {
            if(!string.IsNullOrEmpty(_lastEnteredAnimationKey))
                _animator.SetBool(key, false);
            
            _lastEnteredAnimationKey = key;
            _animator.SetBool(key, true);
        }
    }
}