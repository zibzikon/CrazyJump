using System.Collections.Generic;
using Kernel.Extensions;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.GamePlay.ValuePanel.Data;
using static Kernel.GamePlay.ValuePanel.Data.MathematicalFunctionType;
using static Kernel.GamePlay.ValuePanel.Data.ValuePanelPlacementType;

namespace Kernel.GamePlay.GameBoard
{
    public class RandomGameBoardConfigurationGenerator : IGameBoardConfigurationGenerator
    {
        private readonly GameBoardChunkConfiguration[] _chunks;

        public RandomGameBoardConfigurationGenerator(GameBoardChunkConfiguration[] chunks)
        {
            _chunks = chunks;
        }
        
        public GameBoardConfiguration GenerateConfiguration(int difficulty)
        {
            var accumulatedDifficulty = 0;
            var chunks = new List<GameBoardChunkConfiguration>();
            var maxHeightJump = 0f;
                
            while (accumulatedDifficulty < difficulty)
            {
                var chunk = _chunks.SelectRandomItem();
                accumulatedDifficulty += chunk.SelectionDifficulty;
                var bestConfiguration = GetBestValuePanelInChunk(chunk);
                
                maxHeightJump =
                    maxHeightJump.ProcessMathematicalFunction(bestConfiguration.FunctionType, bestConfiguration.Value);
                
                chunks.Add(chunk);
            }

            return new GameBoardConfiguration(5f, maxHeightJump, chunks.ToArray(), 
                new Dictionary<ValuePanelPlacementType, float>()
            {
                [Center] = 0f,
                [Left] = -1.25f,
                [Right] = 1.25f
            });
        }

        private ValuePanelConfiguration GetBestValuePanelInChunk(GameBoardChunkConfiguration chunk)
        {
            var panels = chunk.Panels;
            
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
                    bestFunction.IsPositive() && function.IsNegative() && bestValue < value ||
                    function == Multiply && value == 0)
                    continue;
                        
                bestConfigurationIndex = i;
                bestFunction = function;
                bestValue = value;
            }

            return bestConfigurationIndex != -1? panels[bestConfigurationIndex] : panels[0];
        }
    }
}