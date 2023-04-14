using System.Collections.Generic;
using Kernel.Mediators;

namespace Kernel.Systems.UI
{
    public class ShowMenuOnLevelGeneratedSystem : GenerateNewLevelReactiveSystem
    {
        private readonly IMediator _mediator;

        public ShowMenuOnLevelGeneratedSystem(LevelContext context, IMediator mediator) : base(context) => _mediator = mediator;

        protected override void Execute(List<LevelEntity> entities)
        {
            foreach (var _ in entities)
                _mediator.ShowMenu();
        }
    }
}