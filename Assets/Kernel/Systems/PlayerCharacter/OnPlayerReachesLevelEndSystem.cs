using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacter
{
    public class OnPlayerReachesLevelEndSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _gameBoardEndParts;

        public OnPlayerReachesLevelEndSystem(GameContext context)
        {
            _playerCharacters = context.GetGroup(AllOf(GameMatcher.PlayerCharacter, Collisionable, CollidedEntityID));
            _gameBoardEndParts = context.GetGroup(AllOf(GameBoardEndPart, Collisionable, ID));
        }

        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            foreach (var endPart in _gameBoardEndParts)
            {
                if(playerCharacter.collidedEntityID.Value != endPart.iD.Value || playerCharacter.isMakingJump) continue;

                playerCharacter.isMakingJump = true;
            }
        }
    }
}