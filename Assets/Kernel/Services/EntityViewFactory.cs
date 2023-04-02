using Foundation.Services.Interfaces;
using Kernel.ECS;
using UnityEngine;

namespace Foundation.Services
{
    public class EntityViewFactory : IEntityViewFactory
    {
        private readonly IResourcesLoader _resourcesLoader;
        private readonly IUnityViewService _viewService;

        public EntityViewFactory(IUnityViewService viewService, IResourcesLoader resourcesLoader)
        {
            _viewService = viewService;
            _resourcesLoader = resourcesLoader;
        }

        public EntityView CreateFromPrefab(EntityView prefab) => _viewService.CreateViewFromPrefab(prefab);

        public EntityView CreateFromResourceName(string name) => CreateFromPrefab(_resourcesLoader.Load<EntityView>(name));

        public EntityView CreateEmpty() => _viewService.CreateEmpty().AddComponent<EntityView>();
    }
}