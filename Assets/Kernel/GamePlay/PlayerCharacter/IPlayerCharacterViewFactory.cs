using Kernel.ECSIntegration;

namespace Kernel.GamePlay.PlayerCharacter
{
    public interface IPlayerCharacterViewFactory
    {
        EntityView CreatePlayerView();
    }
}