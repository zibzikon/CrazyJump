using UnityEngine;

namespace Foundation
{
    public interface IInput
    {
        Vector2 MouseAxis { get; }
        bool LeftMouseButton { get; }
    }
}