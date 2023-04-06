using System;
using System.Collections.Generic;
using System.Globalization;
using Kernel.Components;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using Kernel.Utils.Exceptions;
using log4net.Appender;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kernel.GamePlay.HeightsDiapason
{
    public class HeightsDiapasonViewBehaviour : EntityBehaviour
    {
        [Required, SerializeField] private TextMeshPro _heightIndicationTextMesh;
        [Required, SerializeField] private Renderer _renderer;

        [SerializeField] private List<Color> _colors;

        private void Start()
        {
            if (Entity.isHeightsDiapasonRow || !Entity.hasHeight || Entity.hasRowPosition || Entity.hasRowsCount)
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
            var rowWorldPosition = fullHeight / rowPosition;
            
            _heightIndicationTextMesh.text = rowWorldPosition.ToString("#.##");
            
            _renderer.material.color = GetColor(rowPosition, rowHeight);
            
            CentreTextMesh(rowHeight);
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

        private void CentreTextMesh(float height)
        {
            var textMeshPosition = transform.localPosition;
            _heightIndicationTextMesh.transform.localPosition = textMeshPosition.WithNewY(height / 2);
        }

    }
}