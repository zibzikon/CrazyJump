using System.Collections.Generic;
using Entitas;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems.Level
{
    public class ValuePanelDisappearingSystem : ReactiveSystem<GameEntity>
    {
        public ValuePanelDisappearingSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(Obtained.Added());

        protected override bool Filter(GameEntity valuePanel)
            => AllOf(ValuePanel, Destructable).Matches(valuePanel);

        protected override void Execute(List<GameEntity> valuePanels)
        {
            foreach (var valuePanel in valuePanels)
            {
                var disappearingDuration = valuePanel.disappearingDuration.Value;
                valuePanel.WindUpDuration(disappearingDuration);
                
                valuePanel.isDisappearingStarted = true;
                valuePanel.isLifetimeDuration = true;
            }
        }
    }
}