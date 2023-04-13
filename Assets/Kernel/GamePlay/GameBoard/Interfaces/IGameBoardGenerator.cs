namespace Kernel.GamePlay.GameBoard.Interfaces
{
    public interface IGameBoardGenerator
    {
        GameBoardConfiguration GenerateConfiguration(int difficulty, float startJumpForce);
    }
}