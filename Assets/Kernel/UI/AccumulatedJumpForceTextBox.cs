using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Kernel.UI
{
    public class AccumulatedJumpForceTextBox : MonoBehaviour
    {
        [Required, SerializeField] private TextMeshProUGUI _textMesh;

        public void SetAccumulatedJumpForceValue(float force) => _textMesh.text = force.ToString("#.##");
    }
}