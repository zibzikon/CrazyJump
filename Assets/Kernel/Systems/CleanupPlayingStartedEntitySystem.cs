using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class CleanupPlayingStartedEntitySystem : ICleanupSystem
    {
        private readonly GameContext _gameContext;

        public CleanupPlayingStartedEntitySystem(GameContext gameContext)
        {
            _gameContext = gameContext;
        }
        
        public void Cleanup()
        {
            foreach (var playingStartedEntity in _gameContext.GetEntities())
            {
                if (!playingStartedEntity.isPlayingStarted) continue;
                    playingStartedEntity.Destroy();
            }
        }
    }
}