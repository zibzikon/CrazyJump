using Entitas;
using static LevelMatcher;

namespace Kernel.Systems.Level
{
    public class CleanupLevelGenerationComponentsSystem : ICleanupSystem
    {
        private readonly IGroup<LevelEntity> _generateNewLevelEntities;

        public CleanupLevelGenerationComponentsSystem(LevelContext levelContext)
        {
            _generateNewLevelEntities = levelContext.GetGroup(GenerateNewLevel);
        }
        
        public void Cleanup()
        {
            foreach (var levelEntity in _generateNewLevelEntities.GetEntities())
            {
                levelEntity.Destroy();
            }
        }
    }
}