namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardConfiguration
    {
        public float SpacingBetweenChunks;
        public GameBoardChunkConfiguration[] Chunks;

        public GameBoardConfiguration(float spacingBetweenChunks, GameBoardChunkConfiguration[] chunks)
        {
            SpacingBetweenChunks = spacingBetweenChunks;
            Chunks = chunks;
        }
    }
}