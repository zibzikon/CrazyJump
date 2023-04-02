using UnityEngine;

namespace Kernel.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool TryGetComponent<T>(this MonoBehaviour behaviour, out T component) where T : Component
        {
            component = behaviour.GetComponent<T>();
            
            return component.Exists();
        }
        
        
        public static bool SatisfiesLayerMask(this Component component, LayerMask layerMask) =>
            component.gameObject.SatisfiesLayerMask(layerMask);
        
        public static bool SatisfiesLayerMask (this GameObject gameObject, LayerMask layerMask) =>    
            ((1 << gameObject.layer) & layerMask) != 0;
    }
}