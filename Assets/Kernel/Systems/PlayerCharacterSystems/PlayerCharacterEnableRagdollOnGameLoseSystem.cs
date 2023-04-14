using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterEnableRagdollOnGameLoseSystem : LoseGameReactiveSystem
    {
        private readonly IGroup<GameEntity> _playerCharacter;
        
        public PlayerCharacterEnableRagdollOnGameLoseSystem(GameContext context) : base(context)
        {
            _playerCharacter = context.GetGroup(AllOf(PlayerCharacter).NoneOf(RagdollBody));
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var _ in entities)
            foreach (var playerCharacter in _playerCharacter.GetEntities())
            {
                playerCharacter.isRagdollBody = true;
            }
        }
    }
}