using Kernel.ECSIntegration;
using Kernel.Services;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class PlayerCharacterRegister : MonoBehaviour, IGameEntityRegister
    {
        [SerializeField] private float _horizontalSpeed = 12;
        [SerializeField] private RangeFloat _horizontalMovingBorder;
        [SerializeField] private float _startAccumulatedJumpForce = 1;
        [SerializeField] private float _walkingSpeed = 8;

        public void Register(GameEntity entity)
        {
            entity.isPlayerCharacter = true;
            entity.isMovable = true;
            entity.AddPosition(transform.position);
            
            entity.AddAccumulatedJumpForce(_startAccumulatedJumpForce);
            entity.AddHorizontalBorder(_horizontalMovingBorder);
            entity.AddHorizontalSpeed(_horizontalSpeed);
            entity.AddWalkingSpeed(_walkingSpeed);
            
        }
    }
}