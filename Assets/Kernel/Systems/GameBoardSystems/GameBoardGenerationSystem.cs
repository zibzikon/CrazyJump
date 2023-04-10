using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.GamePlay.GameBoardEndPart;
using UnityEngine;
using static LevelMatcher;

namespace Kernel.Systems.Level
{
    public class GameBoardGenerationSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IGameBoardViewFactory _gameBoardViewFactory;
        private readonly IGameBoardEndPartViewFactory _gameBoardEndPartViewFactory;
        private readonly IGameBoardGenerator _gameBoardGenerator;

        public GameBoardGenerationSystem(LevelContext context, 
            IGameEntityCreator gameEntityCreator,
            IGameBoardViewFactory gameBoardViewFactory, 
            IGameBoardGenerator gameBoardGenerator) : base(context)
        {
            _gameEntityCreator = gameEntityCreator;
            _gameBoardViewFactory = gameBoardViewFactory;
            _gameBoardGenerator = gameBoardGenerator;
        }


        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => entity.hasLevelDifficulty;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var level in entities)
            {

                var configuration = _gameBoardGenerator.GenerateConfiguration(level.levelDifficulty.Value, 5f);
                
                var entity = _gameEntityCreator.CreateEmpty();
                
                entity.isGameBoard = true;
                entity.AddLength(configuration.SpacingBetweenChunks * (configuration.Chunks.Length + 1));
                entity.AddPosition(Vector3.zero);
                
                _gameBoardViewFactory.CreateGameBoardView().Initialize(entity);
                
                level.AddGameBoardConfiguration(configuration);
            }
        }
    }
}