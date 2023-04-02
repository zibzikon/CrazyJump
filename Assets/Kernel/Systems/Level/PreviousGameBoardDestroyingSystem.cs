using System.Collections.Generic;
using Entitas;
using static LevelMatcher;
using static GameMatcher;

namespace Kernel.Systems.Level
{
    public class PreviousGameBoardDestroyingSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGroup<GameEntity> _gameBoards;
        private readonly IGroup<GameEntity> _gameBoardValuePanels;

        public PreviousGameBoardDestroyingSystem(LevelContext context, GameContext gameContext) : base(context)
        {
            _gameBoards = gameContext.GetGroup(AllOf(GameBoard, Destroyable));
            _gameBoardValuePanels = gameContext.GetGroup(AllOf(ValuePanel, Destroyable));
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => true;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var gameBoard in _gameBoards)
            foreach (var valuePanel in _gameBoardValuePanels)
            {
                gameBoard.isDestroyed = true;
                valuePanel.isDestroyed = true;
            }
        }
    }
}