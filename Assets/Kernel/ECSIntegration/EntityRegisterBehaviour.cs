using UnityEngine;

namespace Kernel.ECSIntegration
{
    public abstract class EntityRegisterBehaviour : MonoBehaviour, IGameEntityRegister
    {
        public abstract void Register(GameEntity entity);

    }

}