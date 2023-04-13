using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using UnityEngine;
using static LevelMatcher;
using static GameMatcher;

namespace Kernel.Systems.HeightsDiapasonSystems
{
    public class HeightsDiapasonCreationSystem : ReactiveSystem<LevelEntity>
    {
        private readonly GameContext _gameContext;
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IGroup<GameEntity> _gameBoardEndParts;

        public HeightsDiapasonCreationSystem(LevelContext levelContext, GameContext gameContext,
            IGameEntityCreator gameEntityCreator
            ) : base(levelContext)
        {
            _gameContext = gameContext;
            _gameEntityCreator = gameEntityCreator;
            _gameBoardEndParts = gameContext.GetGroup(AllOf(GameBoardEndPart, Length, Position));
        }


        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => AllOf(GameBoardConfiguration).Matches(entity);

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var level in entities)
            foreach (var gameBoardEndPart in _gameBoardEndParts)
            {
                if (!_gameContext.hasGravityForce) continue;

                var position = gameBoardEndPart.position.Value + gameBoardEndPart.length.Value.AsZVector3();
                var gravityForce = _gameContext.gravityForce.Value;    
                var maxJumpForce = level.gameBoardConfiguration.Value.MaxPossibleJumpForce;
                var maxJumpHeight = CalculateMaxJumpHeight(gravityForce, maxJumpForce); 
                var heightsDiapasonRowsCount = CalculateHeightsDiapasonRowsCount(maxJumpHeight);
                
                var heightsDiapason = _gameEntityCreator.CreateEmpty();
                heightsDiapason.isHeightsDiapason = true;
                heightsDiapason.AddRowsCount(heightsDiapasonRowsCount);
                heightsDiapason.AddMaxHeight(maxJumpHeight);
                heightsDiapason.AddPosition(position);
            }
        }

        private int CalculateHeightsDiapasonRowsCount(float maxJumpHeight)
        {
            const float rowHeight = 1.5f;
            
            return Mathf.RoundToInt(maxJumpHeight / rowHeight);
        }

        private float CalculateMaxJumpHeight(float gravityForce, float jumpForce)
        {
            var n = (gravityForce + jumpForce) / gravityForce;
            var height = jumpForce * n * 0.5f;
            
            return height;
        }
    }
}