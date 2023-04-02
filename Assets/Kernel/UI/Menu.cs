using Kernel.Mediators;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.UI
{
    public class Menu : MonoBehaviour
    {
        [Required, SerializeField] private Mediator _mediator;
        [Required, SerializeField] private Button _playButton;
    
        private void Awake()
        {
            RegisterEvents();
        }

        private void OnDestroy()
        {
            UnregisterEvents();
        }

        private void RegisterEvents()
        {
            _playButton.Click += _mediator.PlayGame;
        }

        private void UnregisterEvents()
        {
            _playButton.Click -= _mediator.PlayGame;
        }
    }
}
