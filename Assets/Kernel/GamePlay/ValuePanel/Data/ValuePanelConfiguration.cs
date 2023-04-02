using System;
using Kernel.GamePlay.ValuePanel;
using Kernel.GamePlay.ValuePanel.Data;

namespace Kernel.GamePlay.GameBoard
{
    [Serializable]
    public class ValuePanelConfiguration
    {
        public float Value;
        public ValuePanelFunctionType FunctionType;
        public ValuePanelMovingType MovingType;
        public ValuePanelPlacementType PlacementType;
    }
}