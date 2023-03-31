using System;

namespace Kernel.UI
{
    public interface IButton
    {
        event Action Click;
    }
}