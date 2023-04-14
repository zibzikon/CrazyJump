using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay
{
    public class DisappearingDurationRegister : EntityRegisterBehaviour
    {
        [SerializeField] private float _duration;
        
        public override void Register(GameEntity entity) => entity.AddDisappearingDuration(_duration);
    }
}