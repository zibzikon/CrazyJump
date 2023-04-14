using System;
using System.Collections.Generic;
using Entitas;
using Kernel.Extensions;
using Kernel.GamePlay.ValuePanel.Data;
using static GameMatcher;
using static Kernel.GamePlay.ValuePanel.Data.MathematicalFunctionType;

namespace Kernel.Systems.PlayerCharacterSystems
{
    public class PlayerCharacterWithPanelInteractionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _characters;
        private readonly IGroup<GameEntity> _collidedPanels;

        
        public PlayerCharacterWithPanelInteractionSystem(GameContext context)
        {
            _collidedPanels = context.GetGroup(AllOf(ValuePanel, Collisionable, ValuePanelValue, ValuePanelFunction).NoneOf(Obtained));
            _characters = context.GetGroup(AllOf(GameMatcher.PlayerCharacter, Collisionable, CollidedEntityID, AccumulatedJumpForce));
        }
        
        public void Execute()
        {
            foreach (var character in _characters)
            foreach (var collidedPanel in _collidedPanels.GetEntities())
            {
                if(character.collidedEntityID.Value != collidedPanel.iD.Value) continue;
                
                character.ReplaceAccumulatedJumpForce(character.accumulatedJumpForce.Value.ProcessMathematicalFunction(collidedPanel.valuePanelFunction.Value,
                        collidedPanel.valuePanelValue.Value)
                );

                collidedPanel.isObtained = true;
            }
        }


    }
}