using Kernel.UI;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Mediators
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private Engine _engine;
        [Required, SerializeField] private Menu _menu;
        
        [Button, HideInEditorMode] public void PlayGame() => _engine.StartPlaying();
        [Button, HideInEditorMode] public void GenerateNewLevel() => _engine.GenerateNewLevel();
        [Button, HideInEditorMode] public void HideMenu() => _menu.Hide();
        [Button, HideInEditorMode] public void ShowMenu() => _menu.Show();
    }
}