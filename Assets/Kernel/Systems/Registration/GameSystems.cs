using Kernel.Systems.Input;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            
            AddInjected<RegisterInputSystem>();
            AddInjected<EmmitInputSystem>();
            
            AddInjected<GameEventSystems>();
            AddInjected<CharacterWithPanelInteractionSystem>();
            AddInjected<PlayerCharacterHorizontalMoveSystem>();
            AddInjected<PlayerCharacterWalkSystem>();
            AddInjected<CameraFollowingPlayerCharacterSystem>();
            AddInjected<MovingSystem>();
        }
    }
}