namespace Kernel.GamePlay.GameBoard
{
    public interface IGameBoardEntityFactory
    {
        GameEntity CreateGameBoardEntity(GameBoardConfiguration configuration);
    }
}