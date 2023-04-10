using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.CameraSystems
{
    public class InitializeFollowingCameraOnPlayerCreatedSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _followingCameras;
        
        public InitializeFollowingCameraOnPlayerCreatedSystem(GameContext context) : base(context)
        {
            _followingCameras = context.GetGroup(AllOf(Camera, FollowingPlayerCharacter));
        }
        
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(GameMatcher.PlayerCharacter.Added());

        protected override bool Filter(GameEntity entity)
            => entity.hasID;
        

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            foreach (var followingCamera in _followingCameras)
            {
                if (followingCamera.hasFollowingEntityID) continue; 

                followingCamera.AddFollowingEntityID(playerCharacter.iD.Value);
            }
        }
    }
}