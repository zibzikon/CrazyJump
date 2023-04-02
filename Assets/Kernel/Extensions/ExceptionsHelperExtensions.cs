using System;

namespace Foundation.Extensions
{
    public static class ExceptionsHelperExtensions
    {
        public static T ThrowIfNull<T>(this T obj)
        {
            if (obj.NotExists())
                throw new NullReferenceException();
            
            return obj;
        }
    }
}