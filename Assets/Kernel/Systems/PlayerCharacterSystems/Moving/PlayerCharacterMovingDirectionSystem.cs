using Entitas;
using Kernel.Extensions;
using Unity.Mathematics;
using UnityEngine;
using static Unity.Mathematics.math;
using static InputMatcher;
using static GameMatcher;
using quaternion = Unity.Mathematics.quaternion;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterMovingDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<InputEntity> _mouses;

        
        public PlayerCharacterMovingDirectionSystem(GameContext gameContext, InputContext inputContext)
        {
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, MovingDirection, DefaultRotation, RotationSensitivity, TargetRotation, Rotation, Movable));
            _mouses = inputContext.GetGroup(AllOf(Mouse, HorizontalAxis));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            foreach (var mouse in _mouses)
            {
                var axis = mouse.horizontalAxis.Value;
                var rotation = playerCharacter.rotation.Value;
                var targetRotation = playerCharacter.defaultRotation.Value;
 
                if (axis != 0 && mouse.isLeftMouse)
                    targetRotation = (rotation.y + axis * playerCharacter.rotationSensitivity.Value).AsYVector3();

                var movingDirection = (Quaternion.AngleAxis(rotation.y, Vector3.up) * Vector3.forward).normalized;
                
                playerCharacter.ReplaceMovingDirection(movingDirection);
                playerCharacter.ReplaceTargetRotation(targetRotation);
                
            }
        }
    }
}