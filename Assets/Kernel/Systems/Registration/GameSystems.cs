using Kernel.Systems.Camera;
using Kernel.Systems.HeightsDiapasonSystems;
using Kernel.Systems.Input;
using Kernel.Systems.Level;
using Kernel.Systems.Player;
using Kernel.Systems.PlayerCharacterSystems;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            AddInjected<InitializeGameSystem>();
            
            AddInjected<RegisterInputSystem>();
            AddInjected<EmmitInputSystem>();
            
            AddInjected<PreviousLevelDestroyingSystem>();
            AddInjected<GameBoardGenerationSystem>();
            AddInjected<GameBoardEndPartCreationSystem>();
            AddInjected<GameBoardValuePlanesGenerationSystem>();
            
            AddInjected<HeightsDiapasonCreationSystem>();
            AddInjected<HeightsDiapasonRowsCreationSystem>();
            
            AddInjected<PlayerCharacterResetOnNewLevelGeneratedSystem>();
            AddInjected<PlayerCharacterCreationSystem>();
            AddInjected<PlayerCharacterPlayingStartSystem>();
            AddInjected<PlayerCharacterWithPanelInteractionSystem>();
            AddInjected<PlayerCharacterMovingDirectionSystem>();
            AddInjected<PlayerCharacterRotationSystem>();
            AddInjected<PlayerCharacterWalkSystem>();
            AddInjected<PlayerCharacterJumpSystem>();
            AddInjected<PlayerCharacterGravitySystem>();
            AddInjected<OnPlayerCharacterReachesLevelEndSystem>();
            
            AddInjected<InitializeFollowingCameraOnPlayerCreatedSystem>();
            AddInjected<CameraFollowingPlayerCharacterSystem>();
            
            AddInjected<MovingSystem>();
            
            AddInjected<GameEventSystems>();
            
            AddInjected<CleanupPlayingStartedEntitySystem>();
            AddInjected<CleanupDestroyedEntitiesSystem>();
            AddInjected<CleanupLevelGenerationComponentsSystem>();
        }
    }
}