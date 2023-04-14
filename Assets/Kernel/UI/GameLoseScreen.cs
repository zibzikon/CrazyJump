using System;
using Kernel.Mediators;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.UI
{
    public class GameLoseScreen : MonoBehaviour
    {
        [Required, SerializeField] private Button _restartLevelButton;
        [Required, SerializeField] private Mediator _mediator;
        private void Awake() => RegisterEvents();

        private void OnDestroy() => UnregisterEvents();

        public void Show()
        {
            _restartLevelButton.gameObject.SetActive(true);
        }

        public void Hide()
        {
            _restartLevelButton.gameObject.SetActive(false);
        }

        private void RegisterEvents() => _restartLevelButton.Click += _mediator.GenerateNewLevel;

        private void UnregisterEvents() => _restartLevelButton.Click -= _mediator.GenerateNewLevel;
    }
}