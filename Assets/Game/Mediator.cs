using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Mediators
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private Engine _engine;
        
        public void PlayGame() => _engine.StartPlaying();
    }
}