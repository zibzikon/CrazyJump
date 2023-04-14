using System.Collections.Generic;
using Entitas;
using static LevelMatcher;

namespace Kernel.Systems
{
    public abstract class GenerateNewLevelReactiveSystem : ReactiveSystem<LevelEntity>
    {

        protected GenerateNewLevelReactiveSystem(LevelContext context) : base(context) { }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity entity) => true;
    }
}