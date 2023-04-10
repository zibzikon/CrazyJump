using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterWalkSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _characters;

        
        public PlayerCharacterWalkSystem(GameContext context, ITime time)
        {
            _time = time;
            _characters = context.GetGroup(AllOf(PlayerCharacter, MovingDirection, Position, Movable, RunningSpeed, Running).NoneOf(MakingJump));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _characters)
            {
                var moveDelta = playerCharacter.movingDirection.Value * playerCharacter.runningSpeed.Value;
                
                if(playerCharacter.hasHorizontalBorder)
                {
                    var border = playerCharacter.horizontalBorder.Value;
                    moveDelta = moveDelta.SetX(moveDelta.x.Clamp(border));
                }
                
                playerCharacter.ReplacePosition(playerCharacter.position.Value + moveDelta * _time.DeltaTime);
            }
        }
    }
}