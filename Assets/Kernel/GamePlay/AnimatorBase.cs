using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay
{
    public abstract class AnimatorBase : MonoBehaviour
    {
        [Required, SerializeField]private Animator _animator;
        
        protected string LastEnteredAnimationKey;
        
        protected void EnterAnimation(string key)
        {
            if (!string.IsNullOrEmpty(LastEnteredAnimationKey))
                ExitAnimation(LastEnteredAnimationKey);
            
            LastEnteredAnimationKey = key;
            _animator.SetBool(key, true);
        }

        protected void ExitAnimation(string key)
        {
            _animator.SetBool(key, false);
        }
    }
}