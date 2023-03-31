using Kernel.ECS;
using UnityEngine;

namespace Kernel.GamePlay.ValuePanel
{
    public class ValuePanelRegister : MonoBehaviour, IGameEntityRegister
    {
        [SerializeField] private int _value;
        [SerializeField] private ValuePanelFunctionType _function;
        
        public void Register(GameEntity entity)
        {
            entity.isValuePanel = true;
            entity.AddValuePanelValue(_value);
            entity.AddValuePanelFunction(_function);
        }
    }
}