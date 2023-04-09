using Kernel.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kernel.GamePlay.Ragdoll
{
    public class HingeAnchorRagdollBodyPart : MonoBehaviour
    {
        [Required, SerializeField] private Rigidbody _connectedBody;
        [SerializeField] private Vector3 _axis;

        private Rigidbody _rigidbody;
        private HingeJoint _joint;
        
        [HideInEditorMode, Button]
        public void EnableAnchor()
        {
            _rigidbody = gameObject.AddComponent<Rigidbody>();
            _rigidbody.isKinematic = true;
            _rigidbody.WakeUp();
             
            _joint = gameObject.AddComponent<HingeJoint>();
            _joint.axis = _axis;
            _joint.connectedBody = _connectedBody;
        }
        
        [HideInEditorMode,Button]
        public void DisableAnchor()
        {
            Destroy(_joint);
            Destroy(_rigidbody);
        }
        
    }
}