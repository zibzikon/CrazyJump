using System.Threading.Tasks;
using UnityEngine;

namespace Foundation
{
    public interface IResourcesLoader
    {
        T Load<T>(string resourceName) where T : Object;
        Task<T> LoadAsync<T>(string resourceName) where T : Object;
    }
}