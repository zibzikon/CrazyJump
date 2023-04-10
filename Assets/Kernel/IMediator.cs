namespace Kernel.Mediators
{
    public interface IMediator
    {
        void PlayGame();
        void GenerateNewLevel();
        void HideMenu();
        void ShowMenu();
        void SetAccumulatedJumpForceValue(float force);
    }
}