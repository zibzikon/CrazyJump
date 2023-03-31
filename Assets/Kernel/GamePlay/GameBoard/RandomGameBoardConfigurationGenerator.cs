using System.Collections.Generic;
using Foundation.Extensions;

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
                var chunk = chunks.SelectRandomItem();
                accumulatedDifficulty += chunk.SelectionDifficulty;
                
                chunks.Add(chunk);
            }

            return new GameBoardConfiguration(2f, chunks.ToArray());
        }
    }
}