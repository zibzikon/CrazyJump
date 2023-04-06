using Kernel.ECSIntegration;
using Kernel.Services;

namespace Kernel.GamePlay.GameBoardEndPart
{
    public class GameBoardEndPartViewFactory : EntityViewFactory, IGameBoardEndPartViewFactory
    {
        public GameBoardEndPartViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) : base(entityViewFactory, viewsProvider)
        {
        }

        public EntityView CreateGameBoardEndPartView()
            => CreateViewFromPrefab(ViewsProvider.GetGameBoardEndPartView(0));
    }
}