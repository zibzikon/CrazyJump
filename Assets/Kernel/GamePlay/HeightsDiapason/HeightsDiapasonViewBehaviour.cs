using System.Collections.Generic;
using Kernel.Components;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using Kernel.Utils.Exceptions;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Kernel.GamePlay.HeightsDiapason
{
    public class HeightsDiapasonViewBehaviour : EntityBehaviour
    {
        [Required, SerializeField] private TextMeshPro _heightIndicationTextMesh;
        [Required, SerializeField] private Renderer _renderer;

        [SerializeField] private List<Color> _colors;

        private void Start()
        {
            if (!Entity.isHeightsDiapasonRow || !Entity.hasHeight || !Entity.hasRowPosition || !Entity.hasRowsCount)
                throw new EntityDoesNotHaveComponentsException(Entity,
                    $"{nameof(HeightsDiapasonRow)}, {nameof(Height)}, {nameof(RowPosition)}, {nameof(RowsCount)} ");
            
            UpdateView();
        }

        private void UpdateView()
        {
            var rowHeight = Entity.height.Value;
            var rowPosition = Entity.rowPosition.Value;
            var rowsCount = Entity.rowsCount.Value;
            
            var fullHeight = rowsCount * rowHeight;
            var rowWorldPosition = (rowPosition + 1) * rowHeight;
            
            _heightIndicationTextMesh.text = rowWorldPosition.ToString("#.##");
            
            _renderer.material.color = GetColor(rowPosition, fullHeight);
            transform.localScale = transform.localScale.WithNewY(rowHeight);
        }

        private Color GetColor(float rowWorldPosition, float fullHeight)
        {

            var colorsCount = _colors.Count;
            
            var colorPosition = rowWorldPosition / (fullHeight / colorsCount);

            var startColorPosition = Mathf.FloorToInt(colorPosition);
            var startColor = _colors[startColorPosition];

            var interpolation = colorPosition - startColorPosition;

            if (startColorPosition < colorsCount - 1)
                return Color.Lerp(startColor, _colors[startColorPosition + 1], interpolation);
            
            return startColor;
        }
        

    }
}