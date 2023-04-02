using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.GamePlay.PlayerCharacter;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacter
{
    public class PlayerCharacterCreationSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IPlayerCharacterViewFactory _playerCharacterViewFactory;

        public PlayerCharacterCreationSystem(GameContext context,
            IGameEntityCreator gameEntityCreator,
            IPlayerCharacterViewFactory playerCharacterViewFactory) : base(context)
        {
            _gameEntityCreator = gameEntityCreator;
            _playerCharacterViewFactory = playerCharacterViewFactory;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(CreatePlayerCharacter);

        protected override bool Filter(GameEntity entity)
            => entity.hasPlayerCharacterConfiguration;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var createPlayerEntity in entities)
            {
                var config = createPlayerEntity.playerCharacterConfiguration.Value;
                
                var entity = _gameEntityCreator.CreateEmpty();
                entity.isPlayerCharacter = true;
                
                entity.AddWalkingSpeed(config.WalkingSpeed);
                entity.AddHorizontalSpeed(config.HorizontalSpeed);
                entity.AddHorizontalBorder(config.HorizontalMovingBorder);
                entity.AddAccumulatedJumpForce(config.StartAccumulatedJumpForce);
                
                _playerCharacterViewFactory.CreatePlayerView().Initialize(entity);
            }
        }
    }
}