using System.Collections.Generic;
using Entitas;
using Foundation;
using Foundation.Extensions;
using UnityEngine;
using static GameMatcher;
using static InputMatcher;

namespace Kernel.Systems
{
    public class PlayerCharacterHorizontalMoveSystem : ReactiveSystem<InputEntity>
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _playerCharacters;

        
        public PlayerCharacterHorizontalMoveSystem(GameContext gameContext, InputContext inputContext, ITime time) : base(inputContext)
        {
            _time = time;
            _playerCharacters = gameContext.GetGroup(AllOf(PlayerCharacter, Movable, Position, HorizontalBorder));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
            => context.CreateCollector(HorizontalAxis);

        protected override bool Filter(InputEntity entity)
            => AllOf(Mouse, LeftMouse).Matches(entity);
        
        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var mouse in entities)
            foreach (var playerCharacter in _playerCharacters)
            {
                var moveDelta = (mouse.horizontalAxis.Value * playerCharacter.horizontalSpeed.Value * _time.DeltaTime).AsXVector3();

                var position = playerCharacter.position.Value;

                var horizontalBorder = playerCharacter.horizontalBorder.Value;
                var clamped = position.WithNewX(Mathf.Clamp(position.x + moveDelta.x, horizontalBorder.start, horizontalBorder.end));
                
                playerCharacter.ReplacePosition(clamped);
            }
        }

    }
}