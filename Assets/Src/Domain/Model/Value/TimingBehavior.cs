using Assets.Src.Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    public partial class Ailment
    {
        /// <summary>
        /// 動作タイミングとタイミング毎の動作定義クラス
        /// </summary>
        [Serializable]
        class TimingBehavior : IKeyValueLike<OperationTiming, List<Behavior>>
        {
            /// <summary>
            /// 動作タイミング
            /// </summary>
            [SerializeField]
            OperationTiming _timing = default(OperationTiming);
            /// <summary>
            /// 動作タイミング
            /// </summary>
            public OperationTiming key => _timing;

            /// <summary>
            /// 動作一覧
            /// </summary>
            [SerializeField]
            List<Behavior> _behaviors = new List<Behavior>();
            /// <summary>
            /// 動作一覧
            /// </summary>
            public List<Behavior> value => _behaviors;
        }
    }
}
