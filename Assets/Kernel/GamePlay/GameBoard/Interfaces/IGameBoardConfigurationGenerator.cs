namespace Kernel.GamePlay.GameBoard.Interfaces
{
    public interface IGameBoardConfigurationGenerator
    {
        GameBoardConfiguration GenerateConfiguration(int difficulty);
    }
}