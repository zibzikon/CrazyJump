using System;

namespace Foundation.Exceptions
{
    public class ResourceNotExistsException : Exception
    {
        public ResourceNotExistsException(string resourceName) :
            base(
                $"The resource: {resourceName} is not exist in current context.Make sure the resource path is given in correct format")
        {
        }
    }
}