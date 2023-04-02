using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Mediators
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private Engine _engine;
        
        [Button, HideInEditorMode] public void PlayGame() => _engine.StartPlaying();
        [Button, HideInEditorMode] public void GenerateNewLevel() => _engine.GenerateNewLevel();
    }
}