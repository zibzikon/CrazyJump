using System;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel
{
    public class MovingDirectionDrawer : EntityBehaviour
    {
        private void OnDrawGizmos()
        {
            if (Entity.NotExists()) return;
            Gizmos.color = Color.black;
            Gizmos.DrawRay(Entity.position.Value, Entity.movingDirection.Value);
        }
    }
}