using System;
using System.Collections.Generic;
using Kernel.GamePlay.ValuePanel.Data;

namespace Kernel.GamePlay.GameBoard
{
    [Serializable]
    public class GameBoardConfiguration
    {
        
        public Dictionary<ValuePanelPlacementType, float> HorizontalPositions;
        public float SpacingBetweenChunks;
        public float MaxPossibleJumpForce;
        public GameBoardChunkConfiguration[] Chunks;

        public GameBoardConfiguration(float spacingBetweenChunks, float maxPossibleJumpForce, GameBoardChunkConfiguration[] chunks, Dictionary<ValuePanelPlacementType, float> horizontalPositions)
        {
            SpacingBetweenChunks = spacingBetweenChunks;
            MaxPossibleJumpForce = maxPossibleJumpForce;
            Chunks = chunks;
            HorizontalPositions = horizontalPositions;
        }
    }
}