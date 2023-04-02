using Kernel.ECSIntegration;
using Kernel.Services;

namespace Kernel.GamePlay
{
    public abstract class EntityViewFactory
    {
        protected readonly IViewsProvider ViewsProvider;
        
        private readonly IEntityViewFactory _entityViewFactory;

        protected EntityViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider)
        {
            _entityViewFactory = entityViewFactory;
            ViewsProvider = viewsProvider;
        }

        protected EntityView CreateViewFromPrefab(EntityView entityView)
            => _entityViewFactory.CreateFromPrefab(entityView);
    }
}