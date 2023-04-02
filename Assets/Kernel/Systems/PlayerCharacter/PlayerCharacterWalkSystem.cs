using Entitas;
using Foundation;
using Foundation.Extensions;
using static GameMatcher;

namespace Kernel.Systems
{
    public class PlayerCharacterWalkSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _characters;

        
        public PlayerCharacterWalkSystem(GameContext context, ITime time)
        {
            _time = time;
            _characters = context.GetGroup(AllOf(GameMatcher.PlayerCharacter, Movable, Position, WalkingSpeed));
        }
        
        public void Execute()
        {
            foreach (var character in _characters)
            {
                var moveDelta = (character.walkingSpeed.Value * _time.DeltaTime).AsZVector3();
                character.ReplacePosition(character.position.Value + moveDelta);
            }
        }
    }
}