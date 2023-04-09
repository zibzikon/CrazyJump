using System;
using System.Collections.Generic;
using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBodyBehaviour : MonoBehaviour
    {
        [SerializeField] private bool _disablePhysicsAtStart;
        private IEnumerable<RagdollBodyPart> _ragdollBodyParts;
        
        private void Awake()
        {
            _ragdollBodyParts = FindRagdollBodyParts();
        }

        private void Start()
        {
            if(_disablePhysicsAtStart)
                DisableRagdollPhysics();
        }

        [HideInEditorMode,Button] public void EnableRagdollPhysics() => _ragdollBodyParts.ForEach(x => x.EnableRagdollPhysics());
        
        [HideInEditorMode,Button] public void DisableRagdollPhysics() => _ragdollBodyParts.ForEach(x => x.DisableRagdollPhysics());

        private IEnumerable<RagdollBodyPart> FindRagdollBodyParts() =>
            gameObject.GetComponentsInChildrens<RagdollBodyPart>();
    }
}