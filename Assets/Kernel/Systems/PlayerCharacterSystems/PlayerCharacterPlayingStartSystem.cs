using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems.Player
{
    public class PlayerCharacterPlayingStartSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _players;

        
        public PlayerCharacterPlayingStartSystem(GameContext context) : base(context)
        {
            _players = context.GetGroup(AllOf(GameMatcher.PlayerCharacter));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(PlayingStarted.Added());

        protected override bool Filter(GameEntity entity) => true;
        
        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var player in _players)
            foreach (var _ in entities)
            {
                if (player.isMovable) continue;

                player.isMovable = true;
            }
        }
    }
}