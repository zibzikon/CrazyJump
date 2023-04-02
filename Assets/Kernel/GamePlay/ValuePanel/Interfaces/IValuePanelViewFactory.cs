using Kernel.ECSIntegration;
using Kernel.GamePlay.ValuePanel.Data;

namespace Kernel.GamePlay.ValuePanel.Interfaces
{
    public interface IValuePanelViewFactory
    {
        EntityView CreateValuePanelView(ValuePanelConfiguration configuration);
    }
}