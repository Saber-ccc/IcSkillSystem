//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月21日-23:07
//Assembly-CSharp

using System.Collections.Generic;
using NPBehave;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node.Composite
{
    [CreateNodeMenu("CabinIcarus/IcSkillSystem/Behave Nodes/Composite/Random Sequence")]
    public class RandomSequenceNode:ACompositeNode
    {
        protected override Node GetNode(List<Node> inputNodes)
        {
            return new RandomSequence(inputNodes.ToArray());
        }
    }
}