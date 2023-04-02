using System.Collections.Generic;
using UnityEngine;

namespace Kernel.Extensions
{
    public static class VectorExtensions
    {
        public static int GetNearestVectorIndex(this IEnumerable<Vector2> vectors, Vector2 position, float maxDistance)
        {
            var nearestIndex = -1;

            var minDistance = maxDistance;

            var index = 0;
            foreach (var vector in vectors)
            {
                var distance = Vector2.Distance(vector, position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestIndex = index;
                }

                index++;
            }

            return nearestIndex;
        }
        
        public static Vector3 WithNewY(this Vector3 vector, float value) => new (vector.x, value, vector.z);
        public static Vector3 WithNewX(this Vector3 vector, float value) => new (value, vector.y, vector.z);
        public static Vector3 WithNewZ(this Vector3 vector, float value) => new (vector.x, vector.y, value);
        
        public static Vector2 WithNewY(this Vector2 vector, float value) => new (vector.x, value);
        public static Vector2 WithNewX(this Vector2 vector, float value) => new (value, vector.y);

    }
}