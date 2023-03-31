using UnityEngine;

namespace Kernel.ECS
{
    [DisallowMultipleComponent]
    public sealed class EntityView : MonoBehaviour
    {
        public GameEntity Entity { get; private set; }
        
        public void Initialize(GameEntity entity)
        {
            Entity = entity;
            
            RegisterListeners();
            RegisterRegisters();
        }

        private void RegisterListeners()
        {
            foreach (var listener in GetComponents<IGameEventListener>())
                listener.Register(Entity);
        }

        private void RegisterRegisters()
        {
            foreach (var register in GetComponents<IGameEntityRegister>())
                register.Register(Entity);
        }
    }
}