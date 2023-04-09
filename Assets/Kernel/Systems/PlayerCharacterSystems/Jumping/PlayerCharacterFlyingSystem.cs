using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterFlyingSystem : IExecuteSystem
    {
        private readonly GameContext _gameContext;
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;
        
        public PlayerCharacterFlyingSystem(GameContext gameContext, ITime time)
        {
            _gameContext = gameContext;
            _time = time;
            _playerCharacters =
                gameContext.GetGroup(AllOf(PlayerCharacter, DirectionalForce, Movable, MakingJump).NoneOf(Running));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                var directionalForce = playerCharacter.directionalForce.Value;
                
                if(!_gameContext.hasGravityForce || directionalForce <= 0)
                {
                    if (directionalForce < 0)
                        playerCharacter.ReplaceDirectionalForce(0);
                    
                    continue;
                }
                
                var gravityForce = _gameContext.gravityForce.Value;
                
                playerCharacter.ReplacePosition(playerCharacter.position.Value + directionalForce.AsYVector3() * _time.DeltaTime);
                playerCharacter.ReplaceDirectionalForce(directionalForce - gravityForce * _time.DeltaTime);
            }
        }
    }
}