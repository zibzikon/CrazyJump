using Foundation;
using static Kernel.Constants.Scenes;

namespace Kernel.StateMachine.States
{
    public class PlayGameState : IGameState
    {
        private readonly ISceneLoader _sceneLoader;

        public PlayGameState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            _sceneLoader.LoadScene(GamePlaySceneName);
        }

        public void Exit()
        {
        }
    }
}