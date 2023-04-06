using System;
using Kernel.GamePlay.ValuePanel.Data;
using UnityEngine;
using Object = UnityEngine.Object;
using static  Kernel.GamePlay.ValuePanel.Data.MathematicalFunctionType;

namespace Kernel.Extensions
{
    public static class CleanCodeExtensions
    {
        public static bool HaveCustomAttribute<T>(this object o)
            => Attribute.GetCustomAttribute(o.GetType(), typeof(T)).Exists();

        public static string GetTypeName(this Type type) => type.Name;

        public static bool IsPositive(this MathematicalFunctionType function)
            => function switch
            {
                Add => true,
                Subtract => true,
                Divide => false,
                Multiply => false,
                _ => throw new InvalidOperationException()
            };

        public static bool IsNegative(this MathematicalFunctionType function) => !function.IsPositive();
        
        public static float ProcessMathematicalFunction(this float value, MathematicalFunctionType functionType, float with)
            => functionType switch
            {
                Add => value + with,
                Subtract => value - with,
                Divide => value / with,
                Multiply => value * with,
                _ => throw new InvalidOperationException()
            };

        public static bool Exists(this object o) => o is not null;

        public static bool Exists(this Object o) => o;

        public static bool NotExists(this object o) => o is null;

        public static bool NotExists(this Object o) => !o;
        
    }
}