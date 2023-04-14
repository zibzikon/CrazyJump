using System.Collections.Generic;
using Entitas;
using Kernel.Mediators;
using static GameMatcher;

namespace Kernel.Systems.UI
{
    public class HideMenuOnPlayingStartedSystem : ReactiveSystem<GameEntity>
    {
        private readonly IMediator _mediator;

        public HideMenuOnPlayingStartedSystem(GameContext context, IMediator mediator) : base(context)
        {
            _mediator = mediator;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(PlayingStarted.Added());

        protected override bool Filter(GameEntity entity)
            => true;

        protected override void Execute(List<GameEntity> playingStartedEntities)
        {
            foreach (var _ in playingStartedEntities)
            {
                _mediator.HideMenu();
            }
        }
    }
}