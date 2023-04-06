using Entitas;
using Kernel.Extensions;
using Unity.Mathematics;
using UnityEngine;
using static Unity.Mathematics.math;
using static InputMatcher;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterMovingDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<InputEntity> _mouses;

        
        public PlayerCharacterMovingDirectionSystem(GameContext gameContext, InputContext inputContext)
        {
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, MovingDirection, DefaultRotation, RotationSpeed, TargetRotation, Rotation, Movable));
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
                    targetRotation = Quaternion.Euler((rotation.eulerAngles.y + axis * playerCharacter.rotationSpeed.Value).AsYVector3());
                
                playerCharacter.ReplaceMovingDirection(rotate(rotation, new float3(0,0,1)));
                playerCharacter.ReplaceTargetRotation(targetRotation);
                
            }
        }
    }
}