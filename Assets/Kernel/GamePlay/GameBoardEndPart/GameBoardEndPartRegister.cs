using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay.GameBoardEndPart
{
    public class GameBoardEndPartRegister : EntityRegisterBehaviour
    {
        [SerializeField] private float _length;
        
        public override void Register(GameEntity entity)
        {
            entity.AddLength(_length);
        }
    }
}