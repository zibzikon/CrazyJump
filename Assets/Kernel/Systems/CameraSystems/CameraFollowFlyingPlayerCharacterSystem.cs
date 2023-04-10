using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems.CameraSystems
{
    public class CameraFollowFlyingPlayerCharacterSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _followingCameras;

            
        public CameraFollowFlyingPlayerCharacterSystem(GameContext gameContext, ITime time)
        {
            _time = time;
            _playerCharacters = gameContext.GetGroup(AllOf(ID, PlayerCharacter, Position));
            _followingCameras = gameContext.GetGroup(AllOf(ID, Camera, FollowingPlayerCharacter, FollowingEntityID, Position, Movable, StartedFollowingFlyingPlayerCharacter, FollowingOffset));
        }
            
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            foreach (var camera in _followingCameras)
            {
                if(playerCharacter.iD.Value != camera.followingEntityID.Value) continue;
                
                var playerCharacterPosition = playerCharacter.position.Value;
                var cameraPosition = camera.position.Value;
                var position = cameraPosition.SetY(camera.followingOffset.Value.y + playerCharacterPosition.y);
                
                camera.ReplacePosition(position);
            }
        }
    }
}