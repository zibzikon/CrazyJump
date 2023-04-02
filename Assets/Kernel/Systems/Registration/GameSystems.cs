using Kernel.Systems.Camera;
using Kernel.Systems.Input;
using Kernel.Systems.Level;
using Kernel.Systems.PlayerCharacter;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            AddInjected<RegisterInputSystem>();
            AddInjected<EmmitInputSystem>();
            
            AddInjected<PreviousGameBoardDestroyingSystem>();
            AddInjected<GameBoardGenerationSystem>();
            AddInjected<GameBoardValuePlanesGenerationSystem>();
            
            AddInjected<PlayerCharacterCreationSystem>();
            AddInjected<PlayerCharacterPlayingStartSystem>();
            AddInjected<PlayerCharacterWithPanelInteractionSystem>();
            AddInjected<PlayerCharacterHorizontalMoveSystem>();
            AddInjected<PlayerCharacterWalkSystem>();
            
            AddInjected<InitializeFollowingCameraOnPlayerCreatedSystem>();
            AddInjected<CameraFollowingPlayerCharacterSystem>();
            
            AddInjected<MovingSystem>();
            
            AddInjected<GameEventSystems>();
            
            AddInjected<CleanupDestroyedEntitiesSystem>();
        }
    }
}