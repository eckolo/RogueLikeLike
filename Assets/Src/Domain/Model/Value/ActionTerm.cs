using Assets.Src.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 行動条件クラス
    /// </summary>
    [Serializable]
    public partial class ActionTerm
    {
        /// <summary>
        /// 該当使用アビリティ
        /// </summary>
        [SerializeField]
        AbilityStationery _ability = default(AbilityStationery);
        /// <summary>
        /// 該当使用アビリティ
        /// </summary>
        public AbilityStationery ability => _ability;

        /// <summary>
        /// 動作対象
        /// </summary>
        [SerializeField]
        TargetDecisionType _targetType = default(TargetDecisionType);
        /// <summary>
        /// 動作対象
        /// </summary>
        public TargetDecisionType targetType => _targetType;

        /// <summary>
        /// 移動方針
        /// </summary>
        [SerializeField]
        MoveType _moveType = default(MoveType);
        /// <summary>
        /// 移動方針
        /// </summary>
        public MoveType moveType => _moveType;

        /// <summary>
        /// 条件値オブジェクト
        /// 全ての条件を満たした場合該当する
        /// （つまりAND条件）
        /// </summary>
        [SerializeField]
        List<TermValue> _termList = new List<TermValue>();

        /// <summary>
        /// 指定されたゲーム状態下でこの条件が真か否か判定する
        /// </summary>
        /// <param name="myself">判定者</param>
        /// <param name="state">ゲーム状態</param>
        /// <returns>条件判定結果</returns>
        public bool Judge(Npc myself, GameState state)
        {
            foreach(var term in _termList) if(!term.Judge(myself, state)) return false;
            return true;
        }
    }
}