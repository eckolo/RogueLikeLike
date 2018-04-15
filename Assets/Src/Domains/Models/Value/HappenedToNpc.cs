﻿using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// NPCを対象とするタイプの動作データオブジェクト
    /// </summary>
    [Serializable]
    public class HappenedToNpc : Happened, ITargeting<Npc>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subject">動作主体設定値</param>
        /// <param name="predicate">動作内容</param>
        /// <param name="target">動作対象</param>
        public HappenedToNpc(Npc subject, Behavior predicate, Npc target = null)
            : base(subject, predicate)
        {
            _target = target ?? subject;
        }

        /// <summary>
        /// 動作対象
        /// 対象無し行動は自身対象扱い
        /// </summary>
        [SerializeField]
        Npc _target;
        /// <summary>
        /// 動作対象
        /// 対象無し行動は自身対象扱い
        /// </summary>
        public Npc target => _target;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public override IGameStates Predicate(IGameStates states)
        {
            throw new NotImplementedException();
        }
    }
}
