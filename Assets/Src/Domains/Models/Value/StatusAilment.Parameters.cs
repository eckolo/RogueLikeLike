using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class StatusAilment
    {
        /// <summary>
        /// 状態異常に対する数値の疑似辞書型オブジェクト
        /// </summary>
        [Serializable]
        public class Parameters : IKeyValueLike<StatusAilment, int>
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
            /// 状態異常値
            /// </summary>
            [SerializeField]
            [Range(0, 120)]
            int _value = 0;
            /// <summary>
            /// 状態異常値
            /// </summary>
            public int value => _value;
        }
    }
}
