using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.CameraSystems
{
    public class StartFollowingFlyingPlayerCharacterSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _followingCameras;

        public StartFollowingFlyingPlayerCharacterSystem(GameContext context) : base(context)
        {
            _followingCameras = context.GetGroup(AllOf(ID, Camera, FollowingPlayerCharacter, FollowingEntityID));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(MakingJump.Added());

        protected override bool Filter(GameEntity playerCharacter)
            => AllOf(ID, PlayerCharacter, Movable).Matches(playerCharacter);

        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            foreach (var followingCamera in _followingCameras)
            {
                if (playerCharacter.iD.Value != followingCamera.followingEntityID.Value) continue;

                followingCamera.isStartedFollowingFlyingPlayerCharacter = true;
            }
        }
    }
}