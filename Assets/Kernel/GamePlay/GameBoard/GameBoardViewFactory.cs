using Kernel.ECSIntegration;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.Services;

namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardViewFactory : EntityViewFactory, IGameBoardViewFactory
    {
        public GameBoardViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) 
            : base(entityViewFactory, viewsProvider) { }

        public EntityView CreateGameBoardView()
            => CreateViewFromPrefab(ViewsProvider.GetGameBoardView(0), "Game Board");
    }
}