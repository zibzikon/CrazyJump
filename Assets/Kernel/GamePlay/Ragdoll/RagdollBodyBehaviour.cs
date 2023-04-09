using System.Collections.Generic;
using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBodyBehaviour : MonoBehaviour
    {
        private IEnumerable<RagdollBodyPart> _ragdollBodyParts;

        private void Awake()
        {
            _ragdollBodyParts = FindRagdollBodyParts();
            DisableRagdollPhysics();
        }

        [Button] public void EnableRagdollPhysics() => _ragdollBodyParts.ForEach(x => x.EnableRagdollPhysics());
        
        [Button] public void DisableRagdollPhysics() => _ragdollBodyParts.ForEach(x => x.DisableRagdollPhysics());

        private IEnumerable<RagdollBodyPart> FindRagdollBodyParts() =>
            gameObject.GetComponentsInChildrens<RagdollBodyPart>();
    }
}