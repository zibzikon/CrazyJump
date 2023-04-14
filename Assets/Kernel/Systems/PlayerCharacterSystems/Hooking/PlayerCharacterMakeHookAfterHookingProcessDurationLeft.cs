using System.Collections.Generic;
using Entitas;
using static GameMatcher;


namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterMakeHookAfterHookingProcessDurationLeft : ReactiveSystem<GameEntity>
    {
        public PlayerCharacterMakeHookAfterHookingProcessDurationLeft(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(DurationUp.Added());

        protected override bool Filter(GameEntity playerCharacter)
            => AllOf(PlayerCharacter, HookingStarted).Matches(playerCharacter);

        protected override void Execute(List<GameEntity> playerCharactes)
        {
            foreach (var playerCharacter in playerCharactes)
            {
                playerCharacter.isHooked = true;
            }
        }
    }
}