using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterResetRotationAfterJumpSystem : ReactiveSystem<GameEntity>
    {
        public PlayerCharacterResetRotationAfterJumpSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(MakingJump.Added());
            
        protected override bool Filter(GameEntity playerCharacter)
            => AllOf(Rotation).NoneOf(Running).Matches(playerCharacter);

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            {
                playerCharacter.ReplaceRotation(Vector3.zero);
            }
        }
}
}