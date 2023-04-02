using System.Collections.Generic;
using Kernel.Extensions;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.GamePlay.ValuePanel.Data;
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
            
            while (accumulatedDifficulty < difficulty)
            {
                var chunk = _chunks.SelectRandomItem();
                accumulatedDifficulty += chunk.SelectionDifficulty;
                
                chunks.Add(chunk);
            }

            return new GameBoardConfiguration(5f, chunks.ToArray(), 
                new Dictionary<ValuePanelPlacementType, float>()
            {
                [Center] = 0f,
                [Left] = -1.25f,
                [Right] = 1.25f
            });
        }
    }
}