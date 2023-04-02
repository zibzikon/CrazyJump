using System;

namespace Foundation.Extensions
{
    public static class FunctionalExtensions
    {
        public static T With<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }

        public static T With<T>(this T obj, Action<T> action, Func<T, bool> predicate)
        {
            if (predicate(obj)) action(obj);

            return obj;
        }

        public static T With<T>(this T obj, Action<T> action, bool condition)
        {
            if (condition) action(obj);

            return obj;
        }
    }
}