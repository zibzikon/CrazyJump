using Foundation.Extensions;
using UnityEngine;

namespace Kernel.ECS
{
    [RequireComponent(typeof(EntityView))]
    public class EntityBehaviour : MonoBehaviour
    {
        private EntityView _view;
        public GameEntity Entity => _view.Entity;
        
        private void Awake()
        {
            _view = GetComponent<EntityView>();
            OnAwake();
        }

        protected virtual void OnAwake() { }
    }
}