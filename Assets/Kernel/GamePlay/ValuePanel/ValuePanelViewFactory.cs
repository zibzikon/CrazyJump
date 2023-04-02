using Kernel.ECSIntegration;
using Kernel.GamePlay.GameBoard;
using Kernel.GamePlay.ValuePanel.Data;
using Kernel.GamePlay.ValuePanel.Interfaces;
using Kernel.Services;

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