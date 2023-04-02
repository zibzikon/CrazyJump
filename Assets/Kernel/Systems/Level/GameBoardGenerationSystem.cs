using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.GamePlay.GameBoard.Interfaces;
using static LevelMatcher;

namespace Kernel.Systems.Level
{
    public class GameBoardGenerationSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IGameBoardViewFactory _gameBoardViewFactory;
        private readonly IGameBoardConfigurationGenerator _gameBoardConfigurationGenerator;

        public GameBoardGenerationSystem(LevelContext context, 
            IGameEntityCreator gameEntityCreator,
            IGameBoardViewFactory gameBoardViewFactory, 
            IGameBoardConfigurationGenerator gameBoardConfigurationGenerator) : base(context)
        {
            _gameEntityCreator = gameEntityCreator;
            _gameBoardViewFactory = gameBoardViewFactory;
            _gameBoardConfigurationGenerator = gameBoardConfigurationGenerator;
        }


        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => entity.hasLevelDifficulty;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var level in entities)
            {

                var configuration = _gameBoardConfigurationGenerator.GenerateConfiguration(level.levelDifficulty.Value);
                
                var entity = _gameEntityCreator.CreateEmpty();
                
                entity.isGameBoard = true;
                entity.AddLength(configuration.SpacingBetweenChunks * configuration.Chunks.Length);
                
                _gameBoardViewFactory.CreateGamePathView().Initialize(entity);
                
                level.AddGameBoardConfiguration(configuration);
            }
        }
    }
}