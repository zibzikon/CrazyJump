using Kernel.ECSIntegration;
using Kernel.Services;

namespace Kernel.GamePlay
{
    public class ViewsProvider : IViewsProvider
    {
        private readonly ViewsResourcesData _data;
        private readonly IResourcesLoader _resourcesLoader;

        public ViewsProvider(ViewsResourcesData data, IResourcesLoader resourcesLoader)
        {
            _data = data;
            _resourcesLoader = resourcesLoader;
        }

        public EntityView GetValuePanelView(int index) => LoadView(_data.ValuePanelViews[index]);
        
        public EntityView GetPlayerCharacterView(int index) => LoadView(_data.PlayerCharacterViews[index]);
        
        public EntityView GetGameBoardView(int index) => LoadView(_data.GameBoardViews[index]);

        public EntityView LoadView(string viewResourceName) => _resourcesLoader.Load<EntityView>(viewResourceName);
    }
}