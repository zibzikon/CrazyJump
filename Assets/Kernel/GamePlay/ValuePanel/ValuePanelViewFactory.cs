using Foundation.Services.Interfaces;
using Kernel.ECS;
using Kernel.GamePlay.GameBoard;

namespace Kernel.GamePlay.ValuePanel
{
    public class ValuePanelViewFactory : EntityViewFactory, IValuePanelViewFactory
    {
        public ValuePanelViewFactory(IEntityViewFactory entityViewFactory, IViewsProvider viewsProvider) 
            : base(entityViewFactory, viewsProvider) { }

        public EntityView CreateValuePanelView(ValuePanelConfiguration configuration)
            => CreateViewFromPrefab(ViewsProvider.GetValuePanelView(0));
    
    }
}