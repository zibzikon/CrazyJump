using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Camera
{
    public class FollowingCameraRegister : MonoBehaviour, IGameEntityRegister
    {
        [SerializeField] private Vector3 _followingOffset;
        [SerializeField] private float _followingSpeed;
        public void Register(GameEntity entity)
        {
            entity.isCamera = true;
            entity.isMovable = true;
            entity.isFollowingPlayerCharacter = true;
            entity.AddPosition(transform.position);
            entity.AddFollowingOffset(_followingOffset);
            entity.AddFollowSpeed(_followingSpeed);
        }
    }
}