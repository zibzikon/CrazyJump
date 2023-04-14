using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static LevelMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterResetSystem : ReactiveSystem<LevelEntity>
    {
        private readonly IGroup<GameEntity> _playerCharacters;

        public PlayerCharacterResetSystem(LevelContext levelContext, GameContext  gameContext) : base(levelContext)
        {
            _playerCharacters = gameContext.GetGroup(GameMatcher.PlayerCharacter);
        }

        protected override ICollector<LevelEntity> GetTrigger(IContext<LevelEntity> context)
            => context.CreateCollector(GenerateNewLevel);

        protected override bool Filter(LevelEntity generateNewLevelEntity)
            => AllOf(PlayerCharacterConfiguration).Matches(generateNewLevelEntity);

        protected override void Execute(List<LevelEntity> generateNewLevelEntities)
        {
            foreach (var generateNewLevelEntity in generateNewLevelEntities)
            foreach (var playerCharacter in _playerCharacters)
            {
                var config = generateNewLevelEntity.playerCharacterConfiguration.Value;
                
                playerCharacter.isMakingJump = false;
                playerCharacter.isMovable = false;
                
                playerCharacter.ReplaceRunningSpeed(config.RunningSpeed);
                playerCharacter.ReplacePosition(Vector3.zero);
                playerCharacter.ReplaceAccumulatedJumpForce(config.StartAccumulatedJumpForce);
                
                if(playerCharacter.hasDirectionalForce) playerCharacter.RemoveDirectionalForce();
                if(playerCharacter.hasCollidedEntityID) playerCharacter.RemoveCollidedEntityID();
            }
        }
    }
}