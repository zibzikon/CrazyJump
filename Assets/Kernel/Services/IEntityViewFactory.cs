using Kernel.ECS;

namespace Foundation.Services.Interfaces
{
    public interface IEntityViewFactory
    {
        EntityView CreateFromPrefab(EntityView prefab);
        EntityView CreateFromResourceName(string name);
        EntityView CreateEmpty();
    }
}