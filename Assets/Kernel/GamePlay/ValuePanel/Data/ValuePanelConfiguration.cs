using System;

namespace Kernel.GamePlay.ValuePanel.Data
{
    [Serializable]
    public class ValuePanelConfiguration
    {
        public float Value;
        public MathematicalFunctionType FunctionType;
        public ValuePanelMovingType MovingType;
        public ValuePanelPlacementType PlacementType;
    }
}