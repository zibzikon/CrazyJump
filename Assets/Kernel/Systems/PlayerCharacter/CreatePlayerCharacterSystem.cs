using System.Collections.Generic;
using Entitas;
using Kernel.ECS;
using static GameMatcher;

namespace Kernel.Systems
{
    public class CreatePlayerCharacterSystem : ReactiveSystem<GameEntity>
    {
        public CreatePlayerCharacterSystem(GameContext context, IGameEntityCreator gameEntityCreator) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(CreatePlayerCharacter);

        protected override bool Filter(GameEntity entity)
            => entity.hasPlayerCharacterConfiguration;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var createPlayerEntity in entities)
            {
                
            }
        }
    }
}