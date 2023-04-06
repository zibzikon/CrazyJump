using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay
{
    public class TransformationsRegister : MonoBehaviour, IGameEntityRegister
    {
        public void Register(GameEntity entity)
        {
            entity.AddPosition(transform.position);
            entity.AddRotation(transform.rotation);
        }
    }
}