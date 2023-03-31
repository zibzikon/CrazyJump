namespace Kernel.GamePlay.GameBoard
{
    public interface IGameBoardConfigurationGenerator
    {
        GameBoardConfiguration GenerateConfiguration(int difficulty);
    }
}