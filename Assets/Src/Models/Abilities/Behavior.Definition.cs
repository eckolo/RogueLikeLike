﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Models.Abilities
{
    public partial class Behavior
    {
        /// <summary>
        /// 挙動定義パラメータ
        /// </summary>
        [Serializable]
        public partial class Definition
        {
            /// <summary>
            /// 挙動定義リスト
            /// </summary>
            [SerializeField]
            List<Behavior> _behaviorList = new List<Behavior>();
            /// <summary>
            /// 挙動定義リスト
            /// </summary>
            public List<Behavior> behaviorList => _behaviorList;

            /// <summary>
            /// 移動可能量
            /// </summary>
            [SerializeField]
            uint _movement = 0;
            /// <summary>
            /// 移動可能量
            /// </summary>
            public uint movement => _movement;

            /// <summary>
            /// 最大射程距離
            /// </summary>
            [SerializeField]
            uint _maxRange = 1;
            /// <summary>
            /// 最大射程距離
            /// </summary>
            public uint maxRange => _maxRange;

            /// <summary>
            /// 最小射程距離
            /// </summary>
            [SerializeField]
            uint _minRange = 1;
            /// <summary>
            /// 最小射程距離
            /// </summary>
            public uint minRange => _minRange;

            /// <summary>
            /// ターゲットタイプ
            /// </summary>
            [SerializeField]
            TargetableType _targetableType = default(TargetableType);
            /// <summary>
            /// ターゲットタイプ
            /// </summary>
            public TargetableType targetableType => _targetableType;

            /// <summary>
            /// 影響を受けるスキルと影響度合い一覧
            /// </summary>
            [SerializeField]
            List<SkillParameter> _affectedSkills = new List<SkillParameter>();
            /// <summary>
            /// 影響を受けるスキルと影響度合いリスト
            /// </summary>
            public IEnumerable<SkillParameter> affectedSkillList => _affectedSkills;
        }
    }
}
