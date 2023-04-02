using Entitas;
using Kernel.ECSIntegration;
using static GameMatcher;

namespace Kernel.Systems
{
    public class ResetLevelSystem : IExecuteSystem
    {
        private readonly IGameEntityCreator _entityCreator;
        private readonly IGroup<GameEntity> _playerCharacters;

        public ResetLevelSystem(GameContext context, IGameEntityCreator entityCreator)
        {
            _entityCreator = entityCreator;
            _playerCharacters = context.GetGroup(AllOf(GameMatcher.PlayerCharacter, AccumulatedJumpForce));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                
            }
        }
    }
}