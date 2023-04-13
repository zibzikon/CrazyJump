using System;
using Kernel.Services;

namespace Kernel.GamePlay.GameBoard
{
    [Serializable]
    public class GameBoardGeneratorConfiguration
    {
        public GameBoardChunkConfiguration[] Chunks;
        public float MaxJumpForce;
    }
}