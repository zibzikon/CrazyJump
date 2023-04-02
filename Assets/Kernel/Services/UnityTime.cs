using UnityEngine;

namespace Kernel.Services
{
    public class UnityTime : ITime
    {
        public float DeltaTime => Time.deltaTime;
    }
}