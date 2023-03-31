using System;
using System.Collections.Generic;
using Entitas;
using Kernel.GamePlay.ValuePanel;
using static GameMatcher;

namespace Kernel.Systems
{
    public class CharacterWithPanelInteractionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _characters;
        private readonly IGroup<GameEntity> _collidedPanels;

        
        public CharacterWithPanelInteractionSystem(GameContext context)
        {
            _collidedPanels = context.GetGroup(AllOf(ValuePanel, Collisionable, ValuePanelValue, ValuePanelFunction).NoneOf(Interacted));
            _characters = context.GetGroup(AllOf(PlayerCharacter, Collisionable, CollidedEntityID, AccumulatedJumpForce));
        }
        
        public void Execute()
        {
            var entitiesToInteract = new List<GameEntity>();
            
            foreach (var character in _characters)
            foreach (var collidedPanel in _collidedPanels)
            {
                if(character.collidedEntityID.Value != collidedPanel.iD.Value) continue;
                
                character.ReplaceAccumulatedJumpForce(CalculateNewJumpForce(
                    character.accumulatedJumpForce.Value,
                    collidedPanel.valuePanelValue.Value,
                    collidedPanel.valuePanelFunction.Value
                    ));
                
                entitiesToInteract.Add(collidedPanel);
            }

            entitiesToInteract.ForEach(x => x.isInteracted = true);
        }

        private float CalculateNewJumpForce(float accumulatedForce, float value, ValuePanelFunctionType functionType)
            => functionType switch
            {
                ValuePanelFunctionType.Add => accumulatedForce + value,
                ValuePanelFunctionType.Subtract => accumulatedForce - value,
                ValuePanelFunctionType.Divide => accumulatedForce / value,
                ValuePanelFunctionType.Multiply => accumulatedForce * value,
                _ => throw new InvalidOperationException()
            };

    }
}