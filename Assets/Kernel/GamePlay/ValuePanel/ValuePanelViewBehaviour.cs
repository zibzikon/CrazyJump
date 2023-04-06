using System;
using System.Globalization;
using Entitas;
using Kernel.Components;
using Kernel.ECSIntegration;
using Kernel.GamePlay.ValuePanel.Data;
using Kernel.Utils.Exceptions;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using static Kernel.GamePlay.ValuePanel.Data.MathematicalFunctionType;

namespace Kernel.GamePlay.ValuePanel
{
    public class ValuePanelViewBehaviour : EntityBehaviour
    {
        [Required, SerializeField] private Renderer _renderer;
        [Required, SerializeField] private TextMeshPro _textMesh;
        [Required, SerializeField] private Material _positiveFunctionMaterial;
        [Required, SerializeField] private Material _negativeFunctionMaterial;
        
        private void Start()
        {
            if (!Entity.hasValuePanelFunction || !Entity.hasValuePanelValue)
                throw new EntityDoesNotHaveComponentsException(Entity, $"{nameof(ValuePanelFunction)}, {nameof(ValuePanelValue)}");

            UpdateView();
        }

        private void UpdateView()
        {
            var value = Entity.valuePanelValue.Value;
            var functionType = Entity.valuePanelFunction.Value;
            
            _textMesh.text = SelectFunctionCharacter(functionType) + value.ToString(CultureInfo.InvariantCulture);

            _renderer.material = SelectMaterial(functionType);
        }

        private Material SelectMaterial(MathematicalFunctionType functionType) =>
            functionType switch
            {
                Add => _positiveFunctionMaterial,
                Subtract => _negativeFunctionMaterial,
                Multiply => _positiveFunctionMaterial,
                Divide => _negativeFunctionMaterial,
                _ => throw new ArgumentOutOfRangeException(nameof(functionType), functionType, null)
            };

        private char SelectFunctionCharacter(MathematicalFunctionType functionType) => 
            functionType switch
            {
                Add => '+',
                Subtract => '-',
                Multiply => '×',
                Divide => '÷',
                _ => throw new ArgumentOutOfRangeException(nameof(functionType), functionType, null)
            };
    }
}