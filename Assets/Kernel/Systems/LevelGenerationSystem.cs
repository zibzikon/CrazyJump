using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class LevelGenerationSystem : ReactiveSystem<GameEntity>
    {
        public LevelGenerationSystem(GameContext context) : base(context) { }
        
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            throw new System.NotImplementedException();
        }

        protected override bool Filter(GameEntity entity)
        {
            throw new System.NotImplementedException();
        }

        protected override void Execute(List<GameEntity> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}