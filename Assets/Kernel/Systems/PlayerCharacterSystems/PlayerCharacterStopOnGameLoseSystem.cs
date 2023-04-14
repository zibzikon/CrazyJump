using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterStopOnGameLoseSystem : LoseGameReactiveSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;

        public PlayerCharacterStopOnGameLoseSystem(GameContext context) : base(context)
        {
            _playerCharacters = context.GetGroup(AllOf(PlayerCharacter, Running, Movable));
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var _ in entities)
            foreach (var playerCharacter in _playerCharacters.GetEntities())
            {
                playerCharacter.isRunning = false;
            }
        }
    }
}