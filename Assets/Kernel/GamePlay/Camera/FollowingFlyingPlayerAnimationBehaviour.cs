using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Camera
{
    public class FollowingFlyingPlayerAnimationBehaviour : EntityEventListenerBehaviour, IStartedFollowingFlyingPlayerCharacterListener
    {
        
        [Required, SerializeField] private FollowingCameraAnimator _followingCameraAnimator;
        
        public override void Register(GameEntity entity) => entity.AddStartedFollowingFlyingPlayerCharacterListener(this);

        public override void Unregister(GameEntity entity) => entity.RemoveStartedFollowingFlyingPlayerCharacterListener(this);

        public void OnStartedFollowingFlyingPlayerCharacter(GameEntity entity) => _followingCameraAnimator.EnterFollowingFlyingPlayerAnimation();
        
    }
}