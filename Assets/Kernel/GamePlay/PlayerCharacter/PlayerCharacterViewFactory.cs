using Foundation.Services.Interfaces;
using Kernel.ECS;

namespace Kernel.GamePlay.PlayerCharacter
{
    public class PlayerCharacterViewFactory : EntityViewFactory,IPlayerCharacterViewFactory
    {
        public PlayerCharacterViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) 
            : base(entityViewFactory, viewsProvider) { }

        public EntityView CreatePlayerView()
            => CreateViewFromPrefab(ViewsProvider.GetPlayerCharacterView(0));
    }

    public interface IPlayerCharacterViewFactory
    {
        EntityView CreatePlayerView();
    }
}