using System;

namespace Assets.Src.Domain.Model.Value
{
    public partial class TargetDecisionType
    {
        /// <summary>
        /// 対象を確定するための条件種別
        /// </summary>
        public enum Determination
        {
            /// <summary>
            /// 自身
            /// </summary>
            MYSELF,
            /// <summary>
            /// 最も近いNPC
            /// </summary>
            NEAR,
            /// <summary>
            /// 最も遠いNPC
            /// </summary>
            AWAY,
            /// <summary>
            /// 最も強いNPC
            /// </summary>
            STRONG,
            /// <summary>
            /// 最も弱いNPC
            /// </summary>
            WEAK,
            /// <summary>
            /// 最も元気なNPC
            /// </summary>
            LIVELY,
            /// <summary>
            /// 最も弱っているNPC
            /// </summary>
            WEAKENED
        }
    }
}
