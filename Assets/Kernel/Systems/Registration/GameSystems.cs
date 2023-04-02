using Kernel.Systems.Input;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            
            AddInjected<GameEventSystems>();
            
            AddInjected<RegisterInputSystem>();
            AddInjected<EmmitInputSystem>();
            
            AddInjected<DestroyPreviousGameBoardSystem>();
            AddInjected<GameBoardGenerationSystem>();
            AddInjected<GameBoardValuePlanesGenerationSystem>();
            
            AddInjected<CharacterWithPanelInteractionSystem>();
            AddInjected<PlayerCharacterHorizontalMoveSystem>();
            AddInjected<PlayerCharacterWalkSystem>();
            AddInjected<CameraFollowingPlayerCharacterSystem>();
            
            AddInjected<MovingSystem>();
            
            AddInjected<CleanupDestroyedEntitiesSystem>();
        }
    }
}