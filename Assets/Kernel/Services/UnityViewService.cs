using Foundation.Extensions;
using Foundation.Services.Interfaces;
using UnityEngine;
using static System.String;
using static Foundation.Constants;

namespace Foundation.Services
{
    public class UnityViewService : IUnityViewService
    {
        private readonly Transform _viewsRoot;

        public UnityViewService() => _viewsRoot = CreateRootTransform();

        public T CreateViewFromPrefab<T>(T prefab, string name = null) where T : MonoBehaviour =>
            Object.Instantiate(prefab, _viewsRoot)
                .With(x => x.name = IsNullOrEmpty(name) ? typeof(T).GetTypeName() : name);

        public GameObject CreateEmpty(string name = "GameObject") => new(name);

        private Transform CreateRootTransform() => new GameObject(ViewsRootName).transform;
    }
}