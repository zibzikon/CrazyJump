namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardChunkConfiguration
    {
        public int SelectionDifficulty;
        public ValuePanelConfiguration[] Panels;

        public GameBoardChunkConfiguration(int selectionDifficulty, ValuePanelConfiguration[] panels)
        {
            SelectionDifficulty = selectionDifficulty;
            Panels = panels;
        }
    }
}