using Entitas;
using Kernel.Extensions;
using static GameMatcher;


namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterStartHookingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _heightsDiapasons;

        
        public PlayerCharacterStartHookingSystem(GameContext gameContext)
        {
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, DirectionalForce, MakingJump, HookingProcessDuration));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters.GetEntities())
            {
                if (playerCharacter.directionalForce.Value != 0) continue;
                
                var hookingProcessDuration = playerCharacter.hookingProcessDuration.Value;

                playerCharacter.WindUpDuration(hookingProcessDuration);
                
                playerCharacter.isHookingStarted = true;
                playerCharacter.isMakingJump = false;
            }
        }
    }
}