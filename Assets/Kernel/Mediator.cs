using System;
using Kernel.UI;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;
using static Sirenix.OdinInspector.ButtonStyle;

namespace Kernel.Mediators
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private Engine _engine;
        [Required, SerializeField] private Menu _menu;
        [FormerlySerializedAs("_gameLooseScreen")] [Required, SerializeField] private GameLoseScreen gameLoseScreen;
        [Required, SerializeField] private AccumulatedJumpForceTextBox _accumulatedJumpForceTextBox;

        [Button(FoldoutButton), HideInEditorMode] public void SetAccumulatedJumpForceValue(float force) => _accumulatedJumpForceTextBox.SetAccumulatedJumpForceValue(force);

        [Button, HideInEditorMode] public void PlayGame() => _engine.StartPlaying();
        [Button, HideInEditorMode] public void GenerateNewLevel() => _engine.GenerateNewLevel();
        [Button, HideInEditorMode] public void HideMenu() => _menu.Hide();
        [Button, HideInEditorMode] public void ShowMenu() => _menu.Show();

        [Button, HideInEditorMode] public void ShowGameLooseScreen() => gameLoseScreen.Show();
        [Button, HideInEditorMode] public void HideGameLooseScreen() => gameLoseScreen.Hide();
    }
}
