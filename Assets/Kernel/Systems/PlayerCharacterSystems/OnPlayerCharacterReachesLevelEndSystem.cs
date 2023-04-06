using Entitas;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class OnPlayerCharacterReachesLevelEndSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _gameBoardEndParts;

        public OnPlayerCharacterReachesLevelEndSystem(GameContext context)
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