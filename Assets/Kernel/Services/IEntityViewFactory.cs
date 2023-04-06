using Kernel.ECSIntegration;

namespace Kernel.Services
{
    public interface IEntityViewFactory
    {
        EntityView CreateFromPrefab(EntityView prefab, string instanceName = "Entity View");
        EntityView CreateFromResourceName(string name, string instanceName = "Entity View");
        EntityView CreateEmpty();
    }
}