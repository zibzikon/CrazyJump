using Zenject;

namespace Kernel.StateMachine
{
    public class GameStateFactory : IGameStateFactory
    {
        private readonly DiContainer _diContainer;

        public GameStateFactory(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }
        
        public T CreateState<T>(IGameStateMachine gameStateMachine) where T : IGameState
        {
            var subContainer = _diContainer.CreateSubContainer();
            
            subContainer.BindInstance(gameStateMachine);
            
            return subContainer.Instantiate<T>();
        }
    }
}