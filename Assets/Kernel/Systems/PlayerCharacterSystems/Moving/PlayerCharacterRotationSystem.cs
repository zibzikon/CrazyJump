using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterRotationSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;

        public PlayerCharacterRotationSystem(GameContext gameContext, ITime time)
        {
            _time = time;
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, Rotation, RotationYBorder, TargetRotation));
        }
         
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                var reachingSpeed = 1f;
                var rotation = playerCharacter.rotation.Value;
                var targetRotation = playerCharacter.targetRotation.Value;
                var rotationYBorder = playerCharacter.rotationYBorder.Value;

                var yRotation =
                    Mathf.Lerp(
                        rotation.y, 
                        Mathf.Clamp(targetRotation.y, rotationYBorder.start, rotationYBorder.end),
                        reachingSpeed * _time.DeltaTime);
                
               playerCharacter.ReplaceRotation(rotation.SetY(yRotation));
            }
        }
    }
}