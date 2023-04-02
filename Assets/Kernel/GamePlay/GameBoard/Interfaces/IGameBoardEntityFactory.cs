namespace Kernel.GamePlay.GameBoard.Interfaces
{
    public interface IGameBoardEntityFactory
    {
        GameEntity CreateGameBoardEntity(GameBoardConfiguration configuration);
    }
}