using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.GamePlay.PlayerCharacter;
using Unity.Mathematics;
using UnityEngine;
using static LevelMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterCreationSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IPlayerCharacterViewFactory _playerCharacterViewFactory;

        public PlayerCharacterCreationSystem(LevelContext context,
            IGameEntityCreator gameEntityCreator,
            IPlayerCharacterViewFactory playerCharacterViewFactory) : base(context)
        {
            _gameEntityCreator = gameEntityCreator;
            _playerCharacterViewFactory = playerCharacterViewFactory;
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(CreatePlayerCharacter);

        protected override bool Filter(LevelEntity entity)
            => entity.hasPlayerCharacterConfiguration;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var createPlayerEntity in entities)
            {
                var config = createPlayerEntity.playerCharacterConfiguration.Value;
                
                var entity = _gameEntityCreator.CreateEmpty();
                
                entity.isPlayerCharacter = true;
                entity.isMovable = true;
                
                entity.AddRunningSpeed(config.RunningSpeed);
                entity.AddHorizontalSpeed(config.HorizontalSpeed);
                entity.AddRotationSensitivity(config.RotationSensitivity);
               
                entity.AddAccumulatedJumpForce(config.StartAccumulatedJumpForce);
               
                entity.AddHorizontalBorder(config.HorizontalMovingBorder);
                entity.AddRotationYBorder(config.RotationYBorder);
                
                entity.AddDefaultRotation(Vector3.zero);
                entity.AddTargetRotation(Vector3.zero);
                entity.AddMovingDirection(Vector3.forward);
                
                _playerCharacterViewFactory.CreatePlayerView().Initialize(entity);
            }
        }
    }
}