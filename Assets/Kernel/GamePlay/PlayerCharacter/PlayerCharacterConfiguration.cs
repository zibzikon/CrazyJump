using System;
using Kernel.Services;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kernel.GamePlay.PlayerCharacter
{
    [Serializable]
    public struct PlayerCharacterConfiguration
    {
        [FormerlySerializedAs("WalkingSpeed")] public float RunningSpeed;
        public float HorizontalSpeed;
        public float RotationSensitivity;

        public float StartAccumulatedJumpForce;
        
        public RangeFloat HorizontalMovingBorder;
        public RangeFloat RotationYBorder;
    }
}