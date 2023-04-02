using System;

namespace Kernel.GamePlay.GameBoard
{
    [Serializable]
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