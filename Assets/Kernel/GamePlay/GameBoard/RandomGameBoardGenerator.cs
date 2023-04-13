using System;
using System.Collections.Generic;
using System.Linq;
using Kernel.Extensions;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.GamePlay.ValuePanel.Data;
using static Kernel.GamePlay.ValuePanel.Data.MathematicalFunctionType;
using static Kernel.GamePlay.ValuePanel.Data.ValuePanelPlacementType;

namespace Kernel.GamePlay.GameBoard
{
    public class RandomGameBoardGenerator : IGameBoardGenerator
    {
        private readonly GameBoardGeneratorConfiguration _configuration;
        
        public RandomGameBoardGenerator(GameBoardGeneratorConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public GameBoardConfiguration GenerateConfiguration(int difficulty, float startJumpForce)
        {
            var accumulatedDifficulty = 0;
            var chunks = new List<GameBoardChunkConfiguration>();
            var maxJumpForce = startJumpForce;
                
            while (accumulatedDifficulty < difficulty)
            {
                var force = maxJumpForce;
                var chunk =_configuration.Chunks.Where(x => IsChunkSatisfies(force, x)).SelectRandomItem();
                
                accumulatedDifficulty += chunk.SelectionDifficulty;
                var bestConfiguration = GetBestValuePanelInChunk(chunk);
                
                maxJumpForce = maxJumpForce.ProcessMathematicalFunction(bestConfiguration.FunctionType, bestConfiguration.Value);

                chunks.Add(chunk);
            }

            return new GameBoardConfiguration(5f, maxJumpForce, chunks.ToArray(), 
                new Dictionary<ValuePanelPlacementType, float>()
            {
                [Center] = 0f,
                [Left] = -1.25f,
                [Right] = 1.25f
            });
        }


        private bool IsChunkSatisfies(float accumulatedJumpForce, GameBoardChunkConfiguration chunk)
        {
            var bestValuePanelConfig = GetBestValuePanelInChunk(chunk);
            accumulatedJumpForce = accumulatedJumpForce.ProcessMathematicalFunction(bestValuePanelConfig.FunctionType,
                bestValuePanelConfig.Value);

            return accumulatedJumpForce > 0 && accumulatedJumpForce <= _configuration.MaxJumpForce;
        }
        
        private ValuePanelConfiguration GetBestValuePanelInChunk(GameBoardChunkConfiguration chunk)
        {
            var panels = chunk.Panels;

            if (panels.Length == 1)
            {
                var panel = panels.First();
                return IsGoodPanelConfiguration(panel) ? panel : new ValuePanelConfiguration();
            }
            
            var bestFunction = Add;
            var bestValue = 0f;
            
            var bestConfigurationIndex = -1;
            for (var i = 0; i < panels.Length; i++)
            {
                var configuration = panels[i];
                var function = configuration.FunctionType;
                var value = configuration.Value;
 
                if (bestFunction.IsPositive() && function.IsNegative() && bestConfigurationIndex != -1 ||
                    bestFunction.IsPositive() && function.IsPositive() && bestValue > value ||
                    bestFunction.IsNegative() && function.IsNegative() && bestValue < value ||
                    function == Multiply && value == 0)
                    continue;
                        
                bestConfigurationIndex = i;
                bestFunction = function;
                bestValue = value;
            }

            return bestConfigurationIndex != -1? panels[bestConfigurationIndex] : panels[0];
        }

        private bool IsGoodPanelConfiguration(ValuePanelConfiguration configuration)
        {
            var function = configuration.FunctionType;
            var value = configuration.Value;
            
            if (function == Multiply && value == 0 ||
            function.IsPositive() && value < 0 ||
            function == Divide && !value.InRange(0.001f, 1) ||
            function == Subtract && value > 0) 
                return false;

            return true;
        }
    }
}