namespace Kernel.Mediators
{
    public interface IMediator
    {
        void PlayGame();
        void GenerateNewLevel();
        void HideMenu();
        void ShowMenu();
        void HideGameLooseScreen();
        void ShowGameLooseScreen();
        void SetAccumulatedJumpForceValue(float force);
    }
}