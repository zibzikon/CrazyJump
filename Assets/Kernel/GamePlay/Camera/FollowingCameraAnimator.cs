using UnityEngine;

namespace Kernel.GamePlay.Camera
{
    public class FollowingCameraAnimator : AnimatorBase
    {
        [SerializeField] private string _followingFlyingPlayerAnimationKey;

        public void EnterFollowingFlyingPlayerAnimation() => EnterAnimation(_followingFlyingPlayerAnimationKey);

    }
}