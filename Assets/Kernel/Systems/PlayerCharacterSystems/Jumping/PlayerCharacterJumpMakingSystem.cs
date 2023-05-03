using Entitas;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterJumpMakingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _gameBoardEndParts;

        public PlayerCharacterJumpMakingSystem(GameContext context)
        {
            _playerCharacters = context.GetGroup(AllOf(PlayerCharacter, Collisionable, CollidedEntityID, Movable));
            _gameBoardEndParts = context.GetGroup(AllOf(GameBoardEndPart, Collisionable, ID));
        }

        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            foreach (var endPart in _gameBoardEndParts)
            {
                if(playerCharacter.collidedEntityID.Value != endPart.iD.Value || playerCharacter.isMakingJump) continue;
                
                playerCharacter.isRunning = false;
                playerCharacter.isMakingJump = true;
            }
        }
    }
}