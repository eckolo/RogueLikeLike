using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Src.Domains;
using Assets.Src.Models.Npcs;
using UnityEngine;

namespace Assets.Src.Models.Behaviors
{
    /// <summary>
    /// 移動行動
    /// </summary>
    public class MoveBehavior : Behavior, ITargeting<Vector2>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subject">動作主体設定値</param>
        /// <param name="movement">移動量設定値</param>
        public MoveBehavior(Npc subject, Vector2 movement) : base(subject)
        {
            this.movement = movement;
        }

        /// <summary>
        /// 移動量（現在座標から移動先座標までの差分）
        /// </summary>
        Vector2 movement = Vector2.zero;
        /// <summary>
        /// 移動先座標
        /// </summary>
        public Vector2 target => subject.location + movement;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public override GameStates Predicate(GameStates states)
        {
            throw new NotImplementedException();
        }
    }
}
