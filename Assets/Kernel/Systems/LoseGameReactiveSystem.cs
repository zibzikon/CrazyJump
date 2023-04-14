using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public abstract class LoseGameReactiveSystem : ReactiveSystem<GameEntity>
    {
        public LoseGameReactiveSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameLose);

        protected override bool Filter(GameEntity entity) => true;
    }
}