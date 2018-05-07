﻿using UnityEngine;
using System;
using Assets.Src.Domains.Models.Entity;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// キャラクターの動作の結果発生した事象を表すデータクラス
    /// </summary>
    [Serializable]
    public class Happened
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="actor">動作主体設定値</param>
        /// <param name="predicate">動作内容</param>
        public Happened(Npc actor, Behavior predicate, Direction direction)
        {
            _actor = actor;
            _predicate = predicate;
            _direction = direction;
        }

        /// <summary>
        /// 動作主体
        /// </summary>
        [SerializeField]
        Npc _actor;
        /// <summary>
        /// 動作主体
        /// </summary>
        public Npc actor => _actor;

        /// <summary>
        /// 動作内容
        /// </summary>
        [SerializeField]
        Behavior _predicate;
        /// <summary>
        /// 動作内容
        /// </summary>
        public Behavior predicate => _predicate;

        /// <summary>
        /// 動作方向
        /// </summary>
        [SerializeField]
        Direction _direction;
        /// <summary>
        /// 動作方向
        /// </summary>
        public Direction direction => _direction;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public IGameStates Predicate(IGameStates states)
        {
            throw new NotImplementedException();
        }
    }
}
