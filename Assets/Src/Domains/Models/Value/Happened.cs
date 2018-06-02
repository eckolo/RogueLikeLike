using UnityEngine;
using System;
using Assets.Src.Domains.Models.Entity;
using System.Collections.Generic;
using Assets.Src.Domains.Service;
using System.Linq;

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
        /// <param name="target"></param>
        /// <param name="variation"></param>
        /// <param name="ailments"></param>
        /// <param name="movement"></param>
        public Happened(
            Npc target,
            Npc.Parameters variation,
            Dictionary<StatusAilment, int> ailmentAmount,
            Dictionary<StatusAilment, int> ailmentDuration,
            Vector2 movement,
            EffectAnimation animation)
        {
            _target = target;
            _variation = variation;
            _ailments = ailmentAmount
                .Join(ailmentDuration,
                amount => amount,
                duration => duration,
                (amount, duration) => new StatusAilment.Parameters(
                    key: amount.Key,
                    amount: amount.Value,
                    duration: duration.Value))
                .ToList();
            _movement = movement;
            _animation = animation;
        }

        /// <summary>
        /// 動作対象
        /// </summary>
        [SerializeField]
        Npc _target;
        /// <summary>
        /// 動作主体
        /// </summary>
        public Npc target => _target;

        /// <summary>
        /// パラメータ変動量
        /// </summary>
        [SerializeField]
        Npc.Parameters _variation;
        /// <summary>
        /// パラメータ変動量
        /// </summary>
        public Npc.Parameters variation => _variation;

        /// <summary>
        /// 状態異常付与量
        /// </summary>
        [SerializeField]
        List<StatusAilment.Parameters> _ailments;
        /// <summary>
        /// 状態異常付与量（レベル）
        /// </summary>
        public Dictionary<StatusAilment, int> ailmentAmount => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Key);
        /// <summary>
        /// 状態異常延長ターン数
        /// </summary>
        public Dictionary<StatusAilment, int> ailmentDuration => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Value);

        /// <summary>
        /// 移動方向・量
        /// </summary>
        [SerializeField]
        Vector2 _movement;
        /// <summary>
        /// 移動方向・量
        /// </summary>
        public Vector2 movement => _movement;

        /// <summary>
        /// 表示エフェクト情報
        /// </summary>
        [SerializeField]
        EffectAnimation _animation;
        /// <summary>
        /// 表示エフェクト情報
        /// </summary>
        public EffectAnimation animation => _animation;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="state">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public GameState Predicate(GameState state)
        {
            throw new NotImplementedException();
        }
    }
}
