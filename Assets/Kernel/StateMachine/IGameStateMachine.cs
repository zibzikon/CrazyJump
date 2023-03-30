namespace Kernel
{
    public interface IGameStateMachine
    {
        void ChangeState<T>() where T : IGameState;
    }
}