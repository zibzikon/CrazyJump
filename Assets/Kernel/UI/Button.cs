using System;

namespace Kernel.UI
{
    public class Button : UnityEngine.UI.Button, IButton
    {
        public event Action Click;

        protected override void Awake()
        {
            onClick.AddListener(() => Click?.Invoke());
        }
    }
}