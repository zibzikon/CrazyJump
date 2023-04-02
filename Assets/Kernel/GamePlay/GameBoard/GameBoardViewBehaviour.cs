using System;
using Entitas;
using Kernel.Components;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using Kernel.Utils.Exceptions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.GameBoard
{
    public class GameBoardViewBehaviour : EntityBehaviour
    {
        [Required, SerializeField] private Transform _scalablePartTransform;

        private void Start()
        {
            if (!Entity.hasLength)
                throw new EntityDoesNotHaveComponentsException(Entity, $"{nameof(Length)}");

            UpdateView();
        }

        private void UpdateView()
        {
            _scalablePartTransform.localScale = _scalablePartTransform.localScale.WithNewZ(Entity.length.Value);
        }
    }
}