using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class MovingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public MovingSystem(GameContext context)
        {
            _movables = context.GetGroup(AllOf(Movable, MovePosition, Position));
        }
        
        public void Execute()
        {
            foreach (var movable in _movables)
            {
                movable.ReplacePosition(movable.position.Value);
            }
        }
    }
} 