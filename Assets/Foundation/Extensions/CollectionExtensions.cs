using System;
using System.Collections.Generic;

namespace Kernel.Extensions
{
    public static class CollectionExtensions
    {
        public static TCollection ForEach<TCollection, TType>(this TCollection collection, Action<TType> action)
            where TCollection : IEnumerable<TType>
        {
            foreach (var element in collection)
                action(element);

            return collection;
        }
    }
}