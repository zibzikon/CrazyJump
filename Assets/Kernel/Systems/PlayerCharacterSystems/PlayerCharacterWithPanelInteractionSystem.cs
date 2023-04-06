using System;
using System.Collections.Generic;
using Entitas;
using Kernel.GamePlay.ValuePanel.Data;
using static GameMatcher;
using static Kernel.GamePlay.ValuePanel.Data.ValuePanelFunctionType;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterWithPanelInteractionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _characters;
        private readonly IGroup<GameEntity> _collidedPanels;

        
        public PlayerCharacterWithPanelInteractionSystem(GameContext context)
        {
            _collidedPanels = context.GetGroup(AllOf(ValuePanel, Collisionable, ValuePanelValue, ValuePanelFunction).NoneOf(Interacted));
            _characters = context.GetGroup(AllOf(GameMatcher.PlayerCharacter, Collisionable, CollidedEntityID, AccumulatedJumpForce));
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
                Add => accumulatedForce + value,
                Subtract => accumulatedForce - value,
                Divide => accumulatedForce / value,
                Multiply => accumulatedForce * value,
                _ => throw new InvalidOperationException()
            };

    }
}