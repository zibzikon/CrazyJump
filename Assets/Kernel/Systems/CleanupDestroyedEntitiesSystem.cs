using Entitas;

namespace Kernel.Systems
{
    public class CleanupDestroyedEntitiesSystem : ICleanupSystem
    {
        private readonly GameContext _gameContext;

        public CleanupDestroyedEntitiesSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
        }
        
        public void Cleanup()
        {
            foreach (var destroyable in _gameContext.GetEntities())
            {
                if(destroyable.isDestroyable && destroyable.isDestroyed)
                    destroyable.Destroy();
            }
        }
    }
}