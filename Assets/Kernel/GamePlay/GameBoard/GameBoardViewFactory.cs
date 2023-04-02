using Foundation.Services.Interfaces;
using Kernel.ECS;

namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardViewFactory : EntityViewFactory, IGameBoardViewFactory
    {
        public GameBoardViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) 
            : base(entityViewFactory, viewsProvider) { }

        public EntityView CreateGamePathView()
            => CreateViewFromPrefab(ViewsProvider.GetGameBoardView(0));
    }
}