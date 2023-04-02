using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel
{
    public class Bootstrap : MonoBehaviour
    {
        [Required, SerializeField] private Engine _engine;
        
        private void Start()
        {
            _engine.BootstrapLevel();
        }
    }
}