using Kernel.Services;
using UnityEngine;

namespace Kernel.Extensions
{
    public static class NumberExtensions
    {
        public static bool InRange(this int number, int min, int max) => number >= min && number <= max;
        public static float Clamp(this float number, float min, float max) => Mathf.Clamp(number, min, max);
        public static float Clamp(this float number, RangeFloat range) => number.Clamp(range.start, range.end);

        public static Vector3 AsVector3(this float value) => new(value, value, value);
        public static Vector3 AsVector2(this float value) => new Vector2(value, value);
        public static Vector3 AsYVector3(this float value) => value.AsYVector2();
        public static Vector3 AsXVector3(this float value) => value.AsXVector2();
        public static Vector3 AsZVector3(this float value) => new(0, 0, value);
        public static Vector2 AsYVector2(this float value) => new(0, value);
        public static Vector2 AsXVector2(this float value) => new(value, 0);
    }
}