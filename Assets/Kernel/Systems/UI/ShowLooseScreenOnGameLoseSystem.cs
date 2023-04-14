using System.Collections.Generic;
using Entitas;
using Kernel.Mediators;
using static GameMatcher;

namespace Kernel.Systems.UI
{
    public class ShowLooseScreenOnGameLoseSystem : ReactiveSystem<GameEntity>
    {
        private readonly IMediator _mediator;

        public ShowLooseScreenOnGameLoseSystem(GameContext context, IMediator mediator) : base(context)
        {
            _mediator = mediator;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(GameLose);

        protected override bool Filter(GameEntity gameLose) => true;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var _ in entities)
            {
                _mediator.ShowGameLooseScreen();
            }
        }
    }
}