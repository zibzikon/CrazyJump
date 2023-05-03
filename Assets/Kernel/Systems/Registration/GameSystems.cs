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
            AddInjected<ValuePlanesGenerationSystem>();

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
            AddInjected<PlayerCharacterResetRotationAfterJumpSystem>();
            AddInjected<PlayerCharacterFlyingSystem>();
            AddInjected<PlayerCharacterJumpMakingSystem>();
            AddInjected<PlayerCharacterMakeHookAfterHookingProcessDurationLeft>();
            AddInjected<PlayerCharacterStartHookingSystem>();
            AddInjected<PlayerCharacterHookToHeightsDiapasonRowSystem>();
            AddInjected<PlayerCharacterRagdollHookingSystem>();
            AddInjected<PlayerCharacterStopOnGameLoseSystem>();
            AddInjected<PlayerCharacterEnableRagdollOnGameLoseSystem>();
            
            AddInjected<LoseGameOnPlayerAccumulatedJumpIsNegativeSystem>();
            
            AddInjected<ValuePanelDisappearingSystem>();
            
            AddInjected<InitializeFollowingCameraOnPlayerCreatedSystem>();
            AddInjected<StartFollowingFlyingPlayerCharacterSystem>();
            AddInjected<CameraFollowRunningPlayerCharacterSystem>();
            AddInjected<CameraFollowFlyingPlayerCharacterSystem>();
            
            AddInjected<ShowLooseScreenOnGameLoseSystem>();
            AddInjected<ShowMenuOnLevelGeneratedSystem>();
            AddInjected<HideLooseScreenOnLevelGeneratedSystem>();
            AddInjected<HideMenuOnPlayingStartedSystem>();
            AddInjected<AccumulatedJumpForceTextUpdatingSystem>();
            
            AddInjected<GameEventSystems>();

            AddInjected<DurationSystem>();
            AddInjected<DestructOnLifeTimeDurationUpSystem>();

            AddInjected<CleanupPlayingStartedEntitySystem>();
            AddInjected<CleanupDestroyedEntitiesSystem>();
            AddInjected<CleanupLevelGenerationComponentsSystem>();
        }
    }
}