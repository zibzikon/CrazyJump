using Entitas;
using Kernel.Extensions;
using Kernel.Services;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems.Camera
{
    public class CameraFollowingPlayerCharacterSystem : IExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;
        private readonly IGroup<GameEntity> _followingCameras;

        
        public CameraFollowingPlayerCharacterSystem(GameContext gameContext, ITime time)
        {
            _time = time;
            _playerCharacters = gameContext.GetGroup(AllOf(ID, GameMatcher.PlayerCharacter, Position));
            _followingCameras = gameContext.GetGroup(AllOf(ID, GameMatcher.Camera, FollowingEntityID, Position, Movable, FollowingOffset, FollowSpeed));
        }
        
        public void Execute()
        {
            foreach (var playerCharacter in _playerCharacters)
            foreach (var camera in _followingCameras)
            {
                if(playerCharacter.iD.Value != camera.followingEntityID.Value) continue;
                
                var cameraPosition = camera.position.Value;
                var rigidPosition = playerCharacter.position.Value.WithNewX(0) + camera.followingOffset.Value;
                
                var smoothedPosition = Vector3.Lerp(cameraPosition, rigidPosition,
                    camera.followSpeed.Value * _time.DeltaTime);

                camera.ReplacePosition(smoothedPosition);
            }
        }
    }
}