using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterRagdollHookingSystem : ReactiveSystem<GameEntity>
    {
        public PlayerCharacterRagdollHookingSystem(GameContext context) : base(context)
        {
            
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(Hooked.Added());

        protected override bool Filter(GameEntity hookingEntity)
            => AllOf(PlayerCharacter).NoneOf(RagdollBody).Matches(hookingEntity);

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            {
                playerCharacter.isRagdollBody = true;
                playerCharacter.isAnchoredToHand = true;
            }
        }
    }
}