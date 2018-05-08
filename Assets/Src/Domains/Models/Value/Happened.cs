using UnityEngine;
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
        /// <param name="target">動作対象地点</param>
        /// <param name="direction">動作方向</param>
        /// <param name="movement">動作主体移動量・方向</param>
        public Happened(Npc actor, Behavior predicate, Vector2 target, Direction direction, Vector2 movement)
        {
            _actor = actor;
            _predicate = predicate;
            _target = target;
            _direction = direction;
            _movement = movement;
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
        /// 動作対象地点
        /// </summary>
        [SerializeField]
        Vector2 _target;
        /// <summary>
        /// 動作対象地点
        /// </summary>
        public Vector2 target => _target;

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
        /// 移動方向・量
        /// </summary>
        [SerializeField]
        Vector2 _movement;
        /// <summary>
        /// 移動方向・量
        /// </summary>
        public Vector2 movement => _movement;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public IGameFoundation Predicate(IGameFoundation states)
        {
            throw new NotImplementedException();
        }
    }
}
