using System;
using Entitas;

namespace Kernel.Utils.Exceptions
{
    public class EntityDoesNotHaveComponentsException : Exception
    {
        public EntityDoesNotHaveComponentsException(Entity entity, string requestsComponentsString, string message = "")
        : base($"The entity : {entity} does not have requests components: ({requestsComponentsString})") { }
    }
}