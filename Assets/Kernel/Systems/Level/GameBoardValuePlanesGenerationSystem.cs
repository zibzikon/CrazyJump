using System.Collections.Generic;
using Entitas;
using Foundation.Extensions;
using Kernel.ECS;
using Kernel.GamePlay.GameBoard;
using Kernel.GamePlay.ValuePanel;
using UnityEngine;
using static LevelMatcher;

namespace Kernel.Systems
{
    public class GameBoardValuePlanesGenerationSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IValuePanelViewFactory _viewFactory;

        public GameBoardValuePlanesGenerationSystem(LevelContext context,
            IGameEntityCreator gameEntityCreator,
            IValuePanelViewFactory viewFactory
            ) : base(context)
        {
            _gameEntityCreator = gameEntityCreator;
            _viewFactory = viewFactory;
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => entity.hasGameBoardConfiguration;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var entity in entities)
            {
                var gameBoardConfiguration = entity.gameBoardConfiguration.Value;
                var chunksSpacing = gameBoardConfiguration.SpacingBetweenChunks;
                
                for (var i = 0; i < gameBoardConfiguration.Chunks.Length; i++)
                {
                    var chunk = gameBoardConfiguration.Chunks[i];

                    var chunkPosition = new Vector3(0, 0, chunksSpacing * (i + 1));
                    
                    SpawnPanelsChunk(chunk, chunkPosition, gameBoardConfiguration);
                }
            }
        }

        private void SpawnPanelsChunk(GameBoardChunkConfiguration chunk, Vector3 chunkPosition, GameBoardConfiguration config)
        {
            for (var j = 0; j < chunk.Panels.Length; j++)
            {
                var valuePanelConfig = chunk.Panels[j];

                var view = _viewFactory.CreateValuePanelView(valuePanelConfig);

                var entity = _gameEntityCreator.CreateEmpty();

                entity.isValuePanel = true;
                entity.AddValuePanelFunction(valuePanelConfig.FunctionType);
                entity.AddValuePanelValue(valuePanelConfig.Value);

                view.Initialize(entity);

                entity.ReplacePosition(
                    chunkPosition.WithNewX(config.HorizontalPositions[valuePanelConfig.PlacementType]));
            }
        }
    }
}