using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class Skill
    {
        /// <summary>
        /// スキルに対する数値の疑似辞書型オブジェクト
        /// </summary>
        [Serializable]
        public class Parameters : IKeyValueLike<Key, int>
        {
            /// <summary>
            /// 対応スキル
            /// </summary>
            [SerializeField]
            Key _skill = default(Key);
            /// <summary>
            /// 対応スキル
            /// </summary>
            public Key skill => _skill;
            /// <summary>
            /// 辞書型変換用プロパティ
            /// </summary>
            public Key key => skill;

            /// <summary>
            /// スキル値
            /// </summary>
            [SerializeField]
            [Range(0, 120)]
            int _value = 0;
            /// <summary>
            /// スキル値
            /// </summary>
            public int value => _value;
        }
    }
}
