using Foundation;

namespace Kernel.States
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
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}