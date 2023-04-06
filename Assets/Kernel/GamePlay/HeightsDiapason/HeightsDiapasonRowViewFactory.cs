using Kernel.ECSIntegration;
using Kernel.Services;

namespace Kernel.GamePlay.HeightsDiapason
{
    public class HeightsDiapasonRowViewFactory :EntityViewFactory, IHeightsDiapasonRowViewFactory
    {
        public HeightsDiapasonRowViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) : base(entityViewFactory, viewsProvider) { }

        public EntityView CreateHeightsDiapasonPartView()
            => CreateViewFromPrefab(ViewsProvider.GetHeightsDiapasonPartView(0));
    }
}