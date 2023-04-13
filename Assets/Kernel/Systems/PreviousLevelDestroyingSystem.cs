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
            _gameBoards = gameContext.GetGroup(AllOf(GameBoard, Destructable).NoneOf(Destructed));
            _gameBoardValuePanels = gameContext.GetGroup(AllOf(ValuePanel, Destructable).NoneOf(Destructed));
            _gameBoardEndParts = gameContext.GetGroup(AllOf(GameBoardEndPart, Destructable).NoneOf(Destructed));
            _heightsDiapasonRows = gameContext.GetGroup(AllOf(HeightsDiapasonRow, Destructable).NoneOf(Destructed));
            _heightsDiapasons = gameContext.GetGroup(AllOf(HeightsDiapason, Destructable).NoneOf(Destructed));
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity) => true;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var gameBoard in _gameBoards.GetEntities()) gameBoard.isDestructed = true;
            foreach (var endPart in _gameBoardEndParts.GetEntities())endPart.isDestructed = true;
            foreach (var valuePanel in _gameBoardValuePanels.GetEntities())valuePanel.isDestructed = true;
            foreach (var heightsDiapasonRow in _heightsDiapasonRows.GetEntities())heightsDiapasonRow.isDestructed = true;
            foreach (var heightsDiapason in _heightsDiapasons.GetEntities()) heightsDiapason.isDestructed = true;
        }
    }
}