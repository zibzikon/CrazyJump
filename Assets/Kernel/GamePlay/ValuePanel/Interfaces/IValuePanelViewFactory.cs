using Kernel.ECS;
using Kernel.GamePlay.GameBoard;

namespace Kernel.GamePlay.ValuePanel
{
    public interface IValuePanelViewFactory
    {
        EntityView CreateValuePanelView(ValuePanelConfiguration configuration);
    }
}