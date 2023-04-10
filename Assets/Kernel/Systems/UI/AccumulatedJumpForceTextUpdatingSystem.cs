using System.Collections.Generic;
using Entitas;
using Kernel.Mediators;
using static GameMatcher;

namespace Kernel.Systems.UI
{
    public class AccumulatedJumpForceTextUpdatingSystem : ReactiveSystem<GameEntity>
    {
        private readonly IMediator _mediator;

        public AccumulatedJumpForceTextUpdatingSystem(GameContext context, IMediator mediator) : base(context)
        {
            _mediator = mediator;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AccumulatedJumpForce);

        protected override bool Filter(GameEntity playerCharacter)
            => AllOf(PlayerCharacter).Matches(playerCharacter);

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            {
                var accumulatedJumpForce = playerCharacter.accumulatedJumpForce.Value;

                _mediator.SetAccumulatedJumpForceValue(accumulatedJumpForce);
            }
        }
    }
}