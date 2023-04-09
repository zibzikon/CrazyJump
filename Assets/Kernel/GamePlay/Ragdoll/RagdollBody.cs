using System;
using System.Collections.Generic;
using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    public class RagdollBody : MonoBehaviour
    {
        [SerializeField] private Collider _interferingCollider;
        [SerializeField] private Animator _interferingAnimator;
        
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

        [HideInEditorMode,Button] 
        public void EnableRagdollPhysics()
        {
            _interferingCollider.enabled = false;
            _interferingAnimator.enabled = false;
            _ragdollBodyParts.ForEach(x => x.EnableRagdollPhysics());
        }

        [HideInEditorMode, Button]
        public void DisableRagdollPhysics()
        {
            _interferingCollider.enabled = true;
            _interferingAnimator.enabled = true;
            _ragdollBodyParts.ForEach(x => x.DisableRagdollPhysics());
        }

        private IEnumerable<RagdollBodyPart> FindRagdollBodyParts() =>
            gameObject.GetComponentsInChildrens<RagdollBodyPart>();
    }
}