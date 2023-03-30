namespace Kernel.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly IGameStateFactory _gameStateFactory;
        private IGameState _currentState;

        public GameStateMachine(IGameStateFactory gameStateFactory)
        {
            _gameStateFactory = gameStateFactory;
        }
        
        public void ChangeState<T>() where T : IGameState
        {
            _currentState?.Exit();
            
            _currentState = _gameStateFactory.CreateState<T>(this);
            _currentState.Enter();
        }
    }
}