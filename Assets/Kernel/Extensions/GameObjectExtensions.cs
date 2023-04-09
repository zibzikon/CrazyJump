using System.Collections.Generic;
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

        public static IEnumerable<T> GetComponentsInChildrens<T>(this GameObject gameObject) where T : Component
        {
            var components = new List<T>();

            foreach (Transform child in gameObject.transform)
            {
                var childComponents = child.GetComponents<T>();
                components.AddRange(childComponents);
                
                components.AddRange(child.gameObject.GetComponentsInChildrens<T>());
            }

            return components;
        }
    }
}