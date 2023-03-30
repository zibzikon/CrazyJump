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
    }
}