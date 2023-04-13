using Kernel.Systems.CameraSystems;
using Kernel.Systems.HeightsDiapasonSystems;
using Kernel.Systems.Input;
using Kernel.Systems.Level;
using Kernel.Systems.Player;
using Kernel.Systems.PlayerCharacterSystems;
using Kernel.Systems.UI;
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
            
            AddInjected<PlayerCharacterResetSystem>();
            AddInjected<PlayerCharacterCreationSystem>();
            AddInjected<PlayerCharacterPlayingStartSystem>();
            AddInjected<PlayerCharacterWithPanelInteractionSystem>();
            AddInjected<PlayerCharacterMovingDirectionSystem>();
            AddInjected<PlayerCharacterRotationSystem>();
            AddInjected<PlayerCharacterWalkSystem>();
            AddInjected<PlayerCharacterJumpSystem>();
            AddInjected<PlayerCharacterFlyingSystem>();
            AddInjected<PlayerCharacterJumpMakingSystem>();
            AddInjected<PlayerCharacterHookingSystem>();
            AddInjected<PlayerCharacterHookingAnimationStartingBehaviour>();
            AddInjected<PlayerCharacterHookToHeightsDiapasonRowSystem>();
            AddInjected<PlayerCharacterRagdollHookingSystem>();
            
            AddInjected<InitializeFollowingCameraOnPlayerCreatedSystem>();
            AddInjected<StartFollowingFlyingPlayerCharacterSystem>();
            AddInjected<CameraFollowRunningPlayerCharacterSystem>();
            AddInjected<CameraFollowFlyingPlayerCharacterSystem>();
            
            AddInjected<AccumulatedJumpForceTextUpdatingSystem>();
            AddInjected<MenuVisibilitySystem>();
            
            AddInjected<GameEventSystems>();
            
            AddInjected<CleanupPlayingStartedEntitySystem>();
            AddInjected<CleanupDestroyedEntitiesSystem>();
            AddInjected<CleanupLevelGenerationComponentsSystem>();
        }
    }
}