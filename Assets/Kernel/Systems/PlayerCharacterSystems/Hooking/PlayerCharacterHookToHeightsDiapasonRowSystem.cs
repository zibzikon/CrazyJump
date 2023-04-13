using System.Collections.Generic;
using Entitas;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterHookToHeightsDiapasonRowSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _heightsDiapasonRows;

        public PlayerCharacterHookToHeightsDiapasonRowSystem(GameContext context) : base(context)
        {
            _heightsDiapasonRows = context.GetGroup(AllOf(ID, HeightsDiapasonRow, RowPosition, Height));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(Hooked.Added());

        protected override bool Filter(GameEntity entity)
            => AllOf(PlayerCharacter, Position).Matches(entity);
        
        protected override void Execute(List<GameEntity> playerCharacters)
        {
            foreach (var playerCharacter in playerCharacters)
            foreach (var row in _heightsDiapasonRows)
            {
                if (row.isHooked) continue;

                var playerVerticalPosition = playerCharacter.position.Value.y;

                var rowHeight = row.height.Value;
                var rowVerticalPosition = row.rowPosition.Value * rowHeight;

                if(!playerVerticalPosition.InRange(rowVerticalPosition, rowVerticalPosition + rowHeight)) continue;

                row.isHooked = true;
                playerCharacter.AddHookedEntityID(row.iD.Value);
            }
        }
    }
}