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
        partial class TermValue
        {
            /// <summary>
            /// 条件判定に用いられる値の種類
            /// </summary>
            [SerializeField]
            ValueType _valueType = default(ValueType);
            /// <summary>
            /// 条件判定に用いられる値の種類
            /// </summary>
            public ValueType valueType => _valueType;

            /// <summary>
            /// 条件適用方式
            /// </summary>
            TermType _termType = default(TermType);
            /// <summary>
            /// 条件適用方式
            /// </summary>
            public TermType termType => _termType;

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
