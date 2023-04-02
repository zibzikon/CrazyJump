using Kernel.ECSIntegration;

namespace Kernel.Services
{
    public interface IEntityViewFactory
    {
        EntityView CreateFromPrefab(EntityView prefab);
        EntityView CreateFromResourceName(string name);
        EntityView CreateEmpty();
    }
}