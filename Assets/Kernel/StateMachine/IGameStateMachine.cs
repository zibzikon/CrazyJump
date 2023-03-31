namespace Kernel.StateMachine
{
    public interface IGameStateMachine
    {
        void ChangeState<T>() where T : IGameState;
    }
}