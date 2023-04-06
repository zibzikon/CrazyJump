using Kernel.ECSIntegration;

namespace Kernel.Services
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

        public EntityView CreateFromPrefab(EntityView prefab, string instanceName = "Entity View") => _viewService.CreateViewFromPrefab(prefab, instanceName);

        public EntityView CreateFromResourceName(string name, string instanceName = "Entity View") => CreateFromPrefab(_resourcesLoader.Load<EntityView>(name), instanceName);

        public EntityView CreateEmpty() => _viewService.CreateEmpty().AddComponent<EntityView>();
    }
}