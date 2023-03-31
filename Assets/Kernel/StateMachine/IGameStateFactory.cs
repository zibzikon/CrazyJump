namespace Kernel.StateMachine
{
    public interface IGameStateFactory
    {
        T CreateState<T>(IGameStateMachine gameStateMachine) where T : IGameState;
    }
}