using System.Threading.Tasks;
using Foundation.Exceptions;
using Foundation.Services.Interfaces;
using Kernel.Extensions;
using UnityEngine;

namespace Foundation.Services
{
    public class UnityResourceLoader : IResourcesLoader
    {
        public T Load<T>(string resourceName) where T : Object
        {
            var resource = Resources.Load<T>(resourceName);

            if (resource.NotExists()) throw new ResourceNotExistsException(resourceName);

            return resource;
        }

        public Task<T> LoadAsync<T>(string resourceName) where T : Object
        {
            var request = Resources.LoadAsync<T>(resourceName);

            if (request.NotExists()) throw new ResourceNotExistsException(resourceName);

            return request.AsTask<T>();
        }
    }
}