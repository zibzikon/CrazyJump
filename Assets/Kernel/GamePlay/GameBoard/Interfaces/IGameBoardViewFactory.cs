using Kernel.ECS;

namespace Kernel.GamePlay.GameBoard
{
    public interface IGameBoardViewFactory
    {
        EntityView CreateGamePathView();
    }
}