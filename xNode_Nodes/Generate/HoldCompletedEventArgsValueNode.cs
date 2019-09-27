using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/VRModule/HoldCompletedEventArgs Value")]
    public partial class HoldCompletedEventArgsValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.XR.WSA.Input.HoldCompletedEventArgs _value;

        public override Type ValueType { get; } = typeof(UnityEngine.XR.WSA.Input.HoldCompletedEventArgs);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}