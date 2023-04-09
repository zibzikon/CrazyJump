using Kernel.Extensions;
using UnityEngine;

namespace Kernel.ECSIntegration
{
    [RequireComponent(typeof(EntityView))]
    public class EntityBehaviour : MonoBehaviour
    {
        private EntityView _view;
        public GameEntity Entity => _view.Entity;
        
        private void Awake()
        {
            _view = GetComponent<EntityView>().ThrowIfNull();
            
            OnAwake();
        }

        protected virtual void OnAwake() { }
    }
}