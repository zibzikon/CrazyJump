using Entitas;

namespace Kernel.Systems.Level
{
    public class CleanupLevelGenerationComponentsSystem : ICleanupSystem
    {
        private readonly LevelContext _levelContext;

        public CleanupLevelGenerationComponentsSystem(LevelContext levelContext)
        {
            _levelContext = levelContext;
        }
        
        public void Cleanup()
        {
            foreach (var levelEntity in _levelContext.GetEntities())
            {
                if(!levelEntity.isGenerateNewLevel) continue;
                
                levelEntity.Destroy();
            }
        }
    }
}