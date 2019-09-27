using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/CapsuleDirection2D Value")]
    public partial class CapsuleDirection2DValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.CapsuleDirection2D _value;

        public override Type ValueType { get; } = typeof(UnityEngine.CapsuleDirection2D);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}