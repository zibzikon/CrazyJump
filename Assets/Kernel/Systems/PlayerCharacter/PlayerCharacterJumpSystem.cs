using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacter
{
    public class PlayerCharacterJumpSystem : ReactiveSystem<GameEntity>
    {
        public PlayerCharacterJumpSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(MakingJump.Added());
        
        protected override bool Filter(GameEntity playerCharacter)
            => AllOf(AccumulatedJumpForce).Matches(playerCharacter);

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            {
                playerCharacter.AddDirectionalForce(playerCharacter.accumulatedJumpForce.Value);
            }
        }
    }
}