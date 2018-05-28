using Assets.Src.Domains.Models.Interface;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class StatusAilment
    {
        /// <summary>
        /// 状態異常に対する数値の疑似辞書型オブジェクト
        /// </summary>
        [Serializable]
        public class Parameters : IKeyValueLike<StatusAilment, KeyValuePair<int, int>>
        {
            /// <summary>
            /// 対応状態異常
            /// </summary>
            [SerializeField]
            StatusAilment _key = default(StatusAilment);
            /// <summary>
            /// 辞書型変換用プロパティ
            /// </summary>
            public StatusAilment key => _key;

            /// <summary>
            /// 状態異常レベル
            /// </summary>
            [SerializeField]
            int _amount = 0;
            /// <summary>
            /// 状態異常継続期間
            /// </summary>
            [SerializeField]
            int _duration = 0;

            /// <summary>
            /// 状態異常値
            /// </summary>
            public KeyValuePair<int, int> value => new KeyValuePair<int, int>(_amount, _duration);
        }
    }
}
