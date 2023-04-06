using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using Kernel.GamePlay.HeightsDiapason;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems.HeightsDiapasonSystems
{
    public class HeightsDiapasonRowsCreationSystem : ReactiveSystem<GameEntity>
    {
        private readonly IHeightsDiapasonRowViewFactory _viewFactory;
        private readonly IGameEntityCreator _gameEntityCreator;

        public HeightsDiapasonRowsCreationSystem(GameContext context, IHeightsDiapasonRowViewFactory viewFactory, 
            IGameEntityCreator gameEntityCreator) : base(context)
        {
            _viewFactory = viewFactory;
            _gameEntityCreator = gameEntityCreator;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(HeightsDiapason);

        protected override bool Filter(GameEntity heightsDiapason)
            => AllOf(MaxHeight, RowsCount, Position).Matches(heightsDiapason);

        protected override void Execute(List<GameEntity> heightsDiapasons)
        {
            foreach (var heightsDiapason in heightsDiapasons)
            {
                var rowsCount = heightsDiapason.rowsCount.Value;
                var rowHeight = heightsDiapason.maxHeight.Value / rowsCount;
                
                for (int i = 0; i < rowsCount ; i++)
                    CreateRow(i, rowHeight, heightsDiapason.position.Value);
                
            }
        }

        private void CreateRow(int position, float height, Vector3 horizontalPosition)
        {
            var highness = position * height;

            var entity = _gameEntityCreator.CreateEmpty();
            entity.isHeightsDiapasonRow = true;

            entity.AddHeight(height);
            entity.ReplacePosition(horizontalPosition + highness.AsYVector3());
            _viewFactory.CreateHeightsDiapasonPartView().Initialize(entity);
        }
    }
}