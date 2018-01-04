using System;
using UnityEngine;

namespace Assets.Src.Models.Npcs
{
    public partial class ActionTerm
    {
        /// <summary>
        /// 条件値オブジェクト
        /// </summary>
        [Serializable]
        class TermValue
        {
            /// <summary>
            /// 条件判定に用いられる値の種類
            /// </summary>
            [SerializeField]
            TermValueType _type = default(TermValueType);
            /// <summary>
            /// 条件判定に用いられる値の種類
            /// </summary>
            public TermValueType type => _type;

            /// <summary>
            /// 判定条件値
            /// </summary>
            [SerializeField]
            int _value = default(int);
            /// <summary>
            /// 判定条件値
            /// </summary>
            public int value => _value;
        }
    }
}
