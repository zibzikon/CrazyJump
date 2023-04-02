using System;
using Object = UnityEngine.Object;

namespace Kernel.Extensions
{
    public static class CleanCodeExtensions
    {
        public static bool HaveCustomAttribute<T>(this object o)
            => Attribute.GetCustomAttribute(o.GetType(), typeof(T)).Exists();

        public static string GetTypeName(this Type type) => type.Name;

        public static bool Exists(this object o) => o is not null;

        public static bool Exists(this Object o) => o;

        public static bool NotExists(this object o) => o is null;

        public static bool NotExists(this Object o) => !o;
    }
}