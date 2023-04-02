using System;
using Foundation;
using UnityEngine;

namespace Kernel.GamePlay.PlayerCharacter
{
    [Serializable]
    public struct PlayerCharacterConfiguration
    {
        public float WalkingSpeed;
        public float HorizontalSpeed;
        public float StartAccumulatedJumpForce;
        public RangeFloat HorizontalMovingBorder;

        public PlayerCharacterConfiguration(float walkingSpeed, float horizontalSpeed, float startAccumulatedJumpForce, RangeFloat horizontalMovingBorder)
        {
            WalkingSpeed = walkingSpeed;
            HorizontalSpeed = horizontalSpeed;
            StartAccumulatedJumpForce = startAccumulatedJumpForce;
            HorizontalMovingBorder = horizontalMovingBorder;
        }
    }
}