using Entitas;
using static GameMatcher;


namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterHookingAnimationStartingBehaviour : IExecuteSystem
    {
        private readonly GameContext _gameContext;
        private readonly IGroup<GameEntity> _playerCharacters;

        
        public PlayerCharacterHookingAnimationStartingBehaviour(GameContext gameContext)
        {
            _gameContext = gameContext;
            _playerCharacters =
                gameContext.GetGroup(AllOf(PlayerCharacter, MakingJump, Position, HookingProcessDuration));
        }   
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters.GetEntities())
            {
                var jumpForce = playerCharacter.accumulatedJumpForce.Value;
                var gravityForce = _gameContext.gravityForce.Value;
                var hookingProcessDuration = playerCharacter.hookingProcessDuration.Value;
                var playerVerticalPosition = playerCharacter.position.Value.y;

                if (!IsPlayerOnSatisfiedHeight(jumpForce, gravityForce, hookingProcessDuration, playerVerticalPosition)) continue;

                //    playerCharacter.isHookingAnimationStarted = true;
            }
        }

        private bool IsPlayerOnSatisfiedHeight(float jumpForce, float gravityForce, float hookingProcessDuration, float currentPlayerVerticalPosition)
        {
            var timeToReachFullHeight = (jumpForce + gravityForce) / gravityForce;
            var timeToReachSatisfiedHeight = timeToReachFullHeight - hookingProcessDuration;

            var satisfiedHeight = jumpForce * timeToReachSatisfiedHeight * 0.5f;
            
            return currentPlayerVerticalPosition >= satisfiedHeight;
        }
    }
}