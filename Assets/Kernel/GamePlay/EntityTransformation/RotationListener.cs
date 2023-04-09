using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay.EntityTransformation
{
    public class RotationListener : MonoBehaviour, IGameEventListener, IRotationListener
    {
        public void Register(GameEntity entity) => entity.AddRotationListener(this);

        public void Unregister(GameEntity entity) => entity.RemoveRotationListener(this);

        public void OnRotation(GameEntity entity, Vector3 value) => transform.localRotation = Quaternion.Euler(value);
    }
}