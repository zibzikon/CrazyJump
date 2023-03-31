using UnityEngine;

namespace Foundation
{
    public class UnityTime : ITime
    {
        public float DeltaTime => Time.deltaTime;
    }
}