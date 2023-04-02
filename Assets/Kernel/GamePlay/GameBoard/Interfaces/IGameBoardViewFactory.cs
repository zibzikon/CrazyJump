using Kernel.ECSIntegration;

namespace Kernel.GamePlay.GameBoard.Interfaces
{
    public interface IGameBoardViewFactory
    {
        EntityView CreateGamePathView();
    }
}