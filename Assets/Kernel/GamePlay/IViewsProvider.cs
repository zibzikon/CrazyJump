using Kernel.ECSIntegration;

namespace Kernel.GamePlay
{
    public interface IViewsProvider
    {
        EntityView GetValuePanelView(int index);
        EntityView GetPlayerCharacterView(int index);
        EntityView GetGameBoardView(int index);
        EntityView GetGameBoardEndPartView(int index);
    }
}