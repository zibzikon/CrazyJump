using Entitas;
using Kernel.ECSIntegration;
using static GameMatcher;

namespace Kernel.Systems
{
    public class LoseGameOnPlayerAccumulatedJumpIsNegativeSystem : IExecuteSystem
    {
        private readonly IGameEntityCreator _entityCreator;
        private readonly IGroup<GameEntity> _playerCharacters;

        public LoseGameOnPlayerAccumulatedJumpIsNegativeSystem(GameContext gameContext, IGameEntityCreator entityCreator)
        {
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, AccumulatedJumpForce, Running));
            _entityCreator = entityCreator;
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                if (playerCharacter.accumulatedJumpForce.Value > 0 ) continue;

                _entityCreator.CreateEmpty().isGameLose = true;
            }
        }
    }
}