using Kernel.ECS;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Camera
{
    public class FollowingCameraRegister : MonoBehaviour, IGameEntityRegister
    {
        [Required, SerializeField] private EntityView _followingEntity;
        [SerializeField] private Vector3 _followingOffset;
        [SerializeField] private float _followingSpeed;
        public void Register(GameEntity entity)
        {
            entity.isCamera = true;
            entity.isMovable = true;
            entity.AddPosition(transform.position);
            entity.AddFollowingEntityID(_followingEntity.Entity.iD.Value);
            entity.AddFollowingOffset(_followingOffset);
            entity.AddFollowSpeed(_followingSpeed);
        }
    }
}