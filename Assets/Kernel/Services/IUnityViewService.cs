using UnityEngine;

namespace Kernel.Services
{
    public interface IUnityViewService
    {
        T CreateViewFromPrefab<T>(T prefab, string name = null) where T : MonoBehaviour;
        GameObject CreateEmpty(string name = "GameObject");
    }
}