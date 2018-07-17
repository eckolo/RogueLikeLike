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
    public partial class Happened
    {
        /// <summary>
        /// ビルダーの生成
        /// </summary>
        public static Builder builder => new Builder();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="target">事象発生対象</param>
        /// <param name="variation">パラメータ変動量</param>
        /// <param name="ailmentAmount">状態異常レベル変動量</param>
        /// <param name="ailmentDuration">状態異常期間変動量</param>
        /// <param name="movement">移動方向・量</param>
        /// <param name="animations">発生エフェクト</param>
        Happened(
           Npc target,
           Npc.Parameters variation,
           Dictionary<Ailment, int> ailmentAmount,
           Dictionary<Ailment, int> ailmentDuration,
           Vector2 movement,
           List<EffectAnimation> animations)
        {
            _target = target;
            _variation = variation;
            if(ailmentAmount == null || ailmentDuration == null) _ailments = null;
            else _ailments = ailmentAmount
               .Join(ailmentDuration,
               amount => amount.Key.name,
               duration => duration.Key.name,
               (amount, duration) => new Ailment.Parameters(
                   key: amount.Key,
                   amount: amount.Value,
                   duration: duration.Value))
               .ToList();
            _movement = movement;
            _animations = animations;
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
        List<Ailment.Parameters> _ailments;
        /// <summary>
        /// 状態異常付与量（レベル）
        /// </summary>
        public Dictionary<Ailment, int> ailmentAmount => _ailments
            ?.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Key);
        /// <summary>
        /// 状態異常延長ターン数
        /// </summary>
        public Dictionary<Ailment, int> ailmentDuration => _ailments
            ?.ToDictionary()
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
        /// 同時発生エフェクト一覧
        /// </summary>
        [SerializeField]
        List<EffectAnimation> _animations = new List<EffectAnimation>();
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        public IEnumerable<EffectAnimation> animations => _animations;

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
