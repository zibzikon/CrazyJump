using System.Linq;
using UnityEngine;

namespace Kernel.Extensions
{
    public static class AnimatorExtensions
    {
        public static float GetAnimationClipLenght(this Animator animator, string animationName)
            => animator.GetAnimationClip(animationName).length;
        
        public static AnimationClip GetAnimationClip(this Animator animator, string animationName) =>
            animator.runtimeAnimatorController.animationClips.First(x => x.name == animationName);
    }
}