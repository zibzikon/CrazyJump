using System.Threading.Tasks;
using UnityEngine;

namespace Foundation.Services.Interfaces
{
    public interface IResourcesLoader
    {
        T Load<T>(string resourceName) where T : Object;
        Task<T> LoadAsync<T>(string resourceName) where T : Object;
    }
}