using Assets.Src.Domains.Models.Entity;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// NPCの行動選択結果を示すパラメータ
    /// </summary>
    [Serializable]
    public class Selected
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ability">使用されるアビリティ</param>
        /// <param name="target">アビリティ使用対象座標</param>
        /// <param name="direction">アビリティ方向</param>
        /// <param name="movement">移動量</param>
        public Selected(Ability ability, Vector2 target, Direction direction, Vector2 movement)
        {
            this.ability = ability;
            this.target = target;
            this.direction = direction;
            this.movement = movement;
        }

        /// <summary>
        /// 使用アビリティ
        /// </summary>
        public Ability ability { get; }

        /// <summary>
        /// 動作対象地点
        /// </summary>
        public Vector2 target { get; }

        /// <summary>
        /// 動作方向
        /// </summary>
        public Direction direction { get; }

        /// <summary>
        /// 移動方向・量
        /// </summary>
        public Vector2 movement { get; }
    }
}
