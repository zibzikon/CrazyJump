using System;

namespace Kernel.GamePlay.ValuePanel.Data
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