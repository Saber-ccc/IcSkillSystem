using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/VRModule/ManipulationCompletedEventArgs Value")]
    public partial class ManipulationCompletedEventArgsValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.XR.WSA.Input.ManipulationCompletedEventArgs _value;

        public override Type ValueType { get; } = typeof(UnityEngine.XR.WSA.Input.ManipulationCompletedEventArgs);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}