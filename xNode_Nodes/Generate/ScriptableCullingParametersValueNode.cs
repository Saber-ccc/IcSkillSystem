using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/CoreModule/ScriptableCullingParameters Value")]
    public partial class ScriptableCullingParametersValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.Rendering.ScriptableCullingParameters _value;

        public override Type ValueType { get; } = typeof(UnityEngine.Rendering.ScriptableCullingParameters);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}