using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.ValuePanel.Animation
{
    public class ValuePanelAnimator : AnimatorBase
    {
        [SerializeField] private string _desappearingAnimationKey;

        public void EnterDisappearingAnimation() => EnterAnimation(_desappearingAnimationKey);
    }
}