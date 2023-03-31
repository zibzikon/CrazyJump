namespace Kernel.StateMachine
{
    public interface IGameState
    {
        void Enter();
        void Exit();
    }
}