using Entitas;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems
{
    public class DurationSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _withDuration;

        
        public DurationSystem(GameContext context, ITime time)
        {
            _time = time;
            _withDuration = context.GetGroup(AllOf(Duration, DurationLeft).NoneOf(DurationUp));
        }        
        
        public void Execute()
        {
            foreach (var withDuration in _withDuration.GetEntities())
            {
                var durationLeft = withDuration.durationLeft.Value - _time.DeltaTime;
                
                withDuration.ReplaceDurationLeft(durationLeft);

                if (!(durationLeft <= 0)) continue;
                
                withDuration.RemoveDurationLeft();
                withDuration.isDurationUp = true;
            }
        }
    }
}