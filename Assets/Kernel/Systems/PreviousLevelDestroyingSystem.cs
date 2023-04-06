using System.Collections.Generic;
using Entitas;
using static LevelMatcher;
using static GameMatcher;

namespace Kernel.Systems.Level
{
    public class PreviousLevelDestroyingSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGroup<GameEntity> _gameBoards;
        private readonly IGroup<GameEntity> _gameBoardValuePanels;
        private readonly IGroup<GameEntity> _gameBoardEndParts;
        private readonly IGroup<GameEntity> _heightsDiapasons;
        private readonly IGroup<GameEntity> _heightsDiapasonRows;

        public PreviousLevelDestroyingSystem(LevelContext context, GameContext gameContext) : base(context)
        {
            _gameBoards = gameContext.GetGroup(AllOf(GameBoard, Destroyable));
            _gameBoardValuePanels = gameContext.GetGroup(AllOf(ValuePanel, Destroyable));
            _gameBoardEndParts = gameContext.GetGroup(AllOf(GameBoardEndPart, Destroyable));
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity)
            => true;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var gameBoard in _gameBoards)
            foreach (var endPart in _gameBoardEndParts)
            foreach (var valuePanel in _gameBoardValuePanels)
            foreach (var heightsDiapasonRow in _heightsDiapasonRows)
            foreach (var heightsDiapason in _heightsDiapasons)
            {
                gameBoard.isDestroyed = true;
                valuePanel.isDestroyed = true;
                endPart.isDestroyed = true;
                heightsDiapasonRow.isDestroyed = true;
                heightsDiapason.Destroy();
            }
        }
    }
}