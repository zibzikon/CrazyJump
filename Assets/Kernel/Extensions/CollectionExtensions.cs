using System;
using System.Collections.Generic;
using System.Linq;

namespace Kernel.Extensions
{
    public static class CollectionExtensions
    {
        public static void ForEach<TType>(this IEnumerable<TType> collection, Action<TType> action)
        {
            foreach (var element in collection)
                action(element);
        }

        public static T SelectRandomItem<T>(this IEnumerable<T> enumerable)
        {
            var random = new Random();
            var array = enumerable.ToArray();
            if (!array.Any())
                return default;

            var index = random.Next(0, array.Length - 1);
            return array[index];
        }
    }
}