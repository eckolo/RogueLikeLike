﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Models.Ability
{
    public partial class AbilityStationery
    {
        /// <summary>
        /// 挙動定義パラメータ
        /// </summary>
        [Serializable]
        class BehaviorDefinition
        {
            /// <summary>
            /// 挙動定義リスト
            /// </summary>
            [SerializeField]
            List<Motion> _motionList = new List<Motion>();
            /// <summary>
            /// 挙動定義リスト
            /// </summary>
            public List<Motion> motionList => _motionList;

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
        }

    }
}