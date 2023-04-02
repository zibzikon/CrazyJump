using UnityEngine;

namespace Kernel.Services
{
    public interface IInput
    {
        Vector2 MouseAxis { get; }
        bool LeftMouseButton { get; }
    }
}