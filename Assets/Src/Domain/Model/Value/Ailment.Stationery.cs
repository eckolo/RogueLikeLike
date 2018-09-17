using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Service;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    public partial class Ailment
    {
        /// <summary>
        /// 状態オブジェクトの雛形
        /// </summary>
        [Serializable]
        public partial class Stationery : Named
        {
            /// <summary>
            /// 動作定義
            /// </summary>
            [SerializeField]
            List<TimingBehavior> _behaviors = new List<TimingBehavior>();
            /// <summary>
            /// 動作定義
            /// </summary>
            public Dictionary<OperationTiming, List<Behavior>> behaviors => _behaviors.ToDictionary();
        }
    }
}
