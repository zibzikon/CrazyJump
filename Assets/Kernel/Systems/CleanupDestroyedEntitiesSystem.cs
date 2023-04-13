using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class CleanupDestroyedEntitiesSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _destroyed;

        public CleanupDestroyedEntitiesSystem(GameContext gameContext)
        {
            _destroyed = gameContext.GetGroup(AllOf(Destructable, Destructed));
        }
        
        public void Cleanup()
        {
            foreach (var destroyable in _destroyed.GetEntities())
            {
                destroyable.Destroy();
            }
        }
    }
}