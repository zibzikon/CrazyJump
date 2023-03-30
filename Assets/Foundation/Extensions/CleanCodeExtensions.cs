using System;
using Object = UnityEngine.Object;

namespace Kernel.Extensions
{
    public static class CleanCodeExtensions
    {
        public static bool HaveCustomAttribute<T>(this object o)
        {
            return Attribute.GetCustomAttribute(o.GetType(), typeof(T)) is not null;
        }

        public static string GetTypeName(this Type type)
        {
            return type.Name;
        }

        public static bool Exists(this object o)
        {
            return o is not null;
        }

        public static bool Exists(this Object o)
        {
            return o;
        }

        public static bool NotExists(this object o)
        {
            return o is null;
        }

        public static bool NotExists(this Object o)
        {
            return !o;
        }
    }
}