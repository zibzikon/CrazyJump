using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacter
{
    public class PlayerCharacterGravitySystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;
        
        public PlayerCharacterGravitySystem(GameContext gameContext, ITime time)
        {
            _time = time;
            _playerCharacters =
                gameContext.GetGroup(AllOf(GameMatcher.PlayerCharacter, DirectionalForce, GravityForce, Movable, MakingJump));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                var directionalForce = playerCharacter.directionalForce.Value;
                playerCharacter.ReplacePosition(playerCharacter.position.Value + directionalForce.AsYVector3() * _time.DeltaTime);
                playerCharacter.ReplaceDirectionalForce(directionalForce - playerCharacter.gravityForce.Value * _time.DeltaTime);
            }
        }
    }
}