using System;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.GamePlay.Ragdoll
{
    [RequireComponent(typeof(Rigidbody), typeof(Collider))]
    public class RagdollBodyPart : MonoBehaviour
    {
        private Collider _collider;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _collider = GetComponent<Collider>().ThrowIfNull();
            _rigidbody = GetComponent<Rigidbody>().ThrowIfNull();
        }

        public void EnableRagdollPhysics()
        {
            _collider.enabled = true;
            _rigidbody.isKinematic = false;
        }
        
        public void DisableRagdollPhysics()
        {
            _collider.enabled = false;
            _rigidbody.isKinematic = true;
        }
    }
}