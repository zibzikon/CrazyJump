using Entitas;
using static GameMatcher;


namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterHookingSystem : IExecuteSystem
    {
        private readonly GameContext _gameContext;
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _heightsDiapasons;

        
        public PlayerCharacterHookingSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, DirectionalForce, MakingJump, HookingProcessDuration));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters.GetEntities())
            {
                if (playerCharacter.directionalForce.Value != 0) continue;
                var hookingProcessDuration = playerCharacter.hookingProcessDuration.Value;
                
                playerCharacter.AddDurationLeft(hookingProcessDuration);
                playerCharacter.AddDuration(hookingProcessDuration);
                
                playerCharacter.isMakingJump = false;
            }
        }
    }
}