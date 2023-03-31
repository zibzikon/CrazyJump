using Foundation;
using static Kernel.Constants.Scenes;

namespace Kernel.StateMachine.States
{
    public class MainMenuState : IGameState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public MainMenuState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            _sceneLoader.LoadScene(MainMenuSceneName);
        }

        public void Exit() { }
    }
}