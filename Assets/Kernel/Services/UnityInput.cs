using UnityEngine;

namespace Kernel.Services
{
    public class UnityInput : IInput
    {
        public Vector2 MouseAxis => new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        public bool LeftMouseButton => Input.GetMouseButton(0);
    }
}