using Entitas;

namespace Kernel.Systems
{
    public class InitializeGameSystem : IInitializeSystem
    {
        private readonly GameContext _gameContext;

        public InitializeGameSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
        }
        
        public void Initialize()
        {
            _gameContext.SetGravityForce(9.81f);
        }
    }
}