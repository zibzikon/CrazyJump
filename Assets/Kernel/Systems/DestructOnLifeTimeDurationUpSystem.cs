using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class DestructOnLifeTimeDurationUpSystem  : ReactiveSystem<GameEntity>
    {
        public DestructOnLifeTimeDurationUpSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(DurationUp);

        protected override bool Filter(GameEntity withLifeTimeUp)
            => AllOf(LifetimeDuration, Destructable).Matches(withLifeTimeUp);

        protected override void Execute(List<GameEntity> withLifeTimeUpEntities)
        {
            foreach (var withLifeTimeUp in withLifeTimeUpEntities)
            {
                withLifeTimeUp.isDestructed = true;
            }
        }
    }
}