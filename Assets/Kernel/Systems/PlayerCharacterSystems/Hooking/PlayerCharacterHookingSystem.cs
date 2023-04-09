using Entitas;
using static GameMatcher;


namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterHookingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _playerCharacters;

        
        public PlayerCharacterHookingSystem(GameContext gameContext)
        {
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, DirectionalForce));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            {
                if (playerCharacter.directionalForce.Value != 0 || !playerCharacter.isMakingJump) continue;

                playerCharacter.isHooking = true;
                playerCharacter.isMakingJump = false;
            }
        }
    }
}