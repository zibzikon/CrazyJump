using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class PlayerCharacterAnimator : AnimatorBase
    {
        [SerializeField] private string _runningAnimationKey;
        [SerializeField] private string _flyingAnimationKey;
        [SerializeField] private string _hookingAnimationKey;
        
        [HideInEditorMode, Button] public void EnterRunningAnimation() => EnterAnimation(_runningAnimationKey);

        [HideInEditorMode, Button] public void EnterFlyingAnimation() => EnterAnimation(_flyingAnimationKey);

        [HideInEditorMode, Button] public void EnterHookingAnimation() => EnterAnimation(_hookingAnimationKey);

    }
}