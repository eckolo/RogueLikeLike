using Assets.Src.Domains.Models.Entity;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
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
            /// 条件判定値取得対象
            /// （動作対象）
            /// </summary>
            [SerializeField]
            TargetType _valueTarget = default(TargetType);
            /// <summary>
            /// 条件判定値取得対象
            /// （動作対象）
            /// </summary>
            public TargetType valueTarget => _valueTarget;

            /// <summary>
            /// 条件適用方式
            /// </summary>
            [SerializeField]
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

            /// <summary>
            /// 指定されたゲーム状態下でこの条件が真か否か判定する
            /// </summary>
            /// <param name="myself">判定者</param>
            /// <param name="states">ゲーム状態</param>
            /// <returns>条件判定結果</returns>
            public bool Judge(Npc myself, IGameStates states)
            {
                throw new NotImplementedException();
            }
        }
    }
}
