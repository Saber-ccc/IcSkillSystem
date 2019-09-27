using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/CoreModule/CullMode Value")]
    public partial class CullModeValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.Rendering.CullMode _value;

        public override Type ValueType { get; } = typeof(UnityEngine.Rendering.CullMode);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}