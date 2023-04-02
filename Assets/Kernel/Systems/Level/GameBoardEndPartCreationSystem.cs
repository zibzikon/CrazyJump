using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using Kernel.GamePlay.GameBoardEndPart;
using static GameMatcher;

namespace Kernel.Systems.Level
{
    public class GameBoardEndPartCreationSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGameEntityCreator _entityCreator;
        private readonly IGameBoardEndPartViewFactory _viewFactory;

        public GameBoardEndPartCreationSystem(GameContext context, IGameEntityCreator entityCreator,
            IGameBoardEndPartViewFactory viewFactory) : base(context)
        {
            _entityCreator = entityCreator;
            _viewFactory = viewFactory;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(GameBoard.Added());

        protected override bool Filter(GameEntity entity)
            => AllOf(Length, Position).Matches(entity);

        protected override void Execute(List<GameEntity> gameBoards)
        {
            foreach (var gameBoard in gameBoards)
            {
                var entity = _entityCreator.CreateEmpty();
                
                entity.isGameBoardEndPart = true;
                
                _viewFactory.CreateGameBoardEndPartView().Initialize(entity);
                
                entity.ReplacePosition(gameBoard.position.Value.WithNewZ(gameBoard.length.Value));
            }
        }
    }
}