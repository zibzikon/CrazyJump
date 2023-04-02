using System;

namespace Kernel.Utils.Exceptions
{
    public class NotImplementsInterfaceException : Exception
    {
        public NotImplementsInterfaceException(Type sourceType, Type interfaceType) :
            base($"The type ({sourceType}) is not implements ({interfaceType}) interface")
        {
        }
    }
}