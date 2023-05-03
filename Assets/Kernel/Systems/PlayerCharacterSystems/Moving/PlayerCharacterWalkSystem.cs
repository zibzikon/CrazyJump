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
            _characters = context.GetGroup(AllOf(PlayerCharacter, MovingDirection, Position, HorizontalBorder, Movable, RunningSpeed, Running).NoneOf(MakingJump));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _characters)
            {
                var border = playerCharacter.horizontalBorder.Value;
                var moveDelta = playerCharacter.movingDirection.Value * playerCharacter.runningSpeed.Value;
                var position = (playerCharacter.position.Value + moveDelta * _time.DeltaTime);
                
                position.SetX(position.x.Clamp(border));


                playerCharacter.ReplacePosition(position);
            }
        }
    }
}