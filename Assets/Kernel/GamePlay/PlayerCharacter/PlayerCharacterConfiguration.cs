using System;
using Kernel.Services;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    [Serializable]
    public struct PlayerCharacterConfiguration
    {
        public float WalkingSpeed;
        public float HorizontalSpeed;
        public float RotationSpeed;

        public float StartAccumulatedJumpForce;
        
        public RangeFloat HorizontalMovingBorder;
        public RangeFloat RotationYBorder;
    }
}