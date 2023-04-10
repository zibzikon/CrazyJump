using System;
using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardPathMaterialTiler : MonoBehaviour
    {
        [SerializeField] private Vector2 _oneUnitTiling;
        
        [Required, SerializeField]private Renderer _renderer;

        private void Start() => CorrectTilingForMaterial();

        [Button] private void CorrectTilingForMaterial() => _renderer.material.mainTextureScale = CalculateTiling();

        private Vector2 CalculateTiling() => _oneUnitTiling.MultiplyY(transform.lossyScale.z);

    }
}