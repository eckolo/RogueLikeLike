using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Src.Domains;
using Assets.Src.Models.Abilities;
using Assets.Src.Models.Npcs;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// 位置を対象とするタイプの動作データオブジェクト
    /// </summary>
    public class HappenedToLocation : Happened, ITargeting<Vector2>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subject">動作主体設定値</param>
        /// <param name="predicate">動作内容</param>
        /// <param name="target">動作対象地点座標</param>
        public HappenedToLocation(Npc subject, Behavior predicate, Vector2 target)
            : base(subject, predicate)
        {
            _target = target;
        }

        /// <summary>
        /// 動作対象地点座標
        /// </summary>
        Vector2 _target;
        /// <summary>
        /// 動作対象地点座標
        /// </summary>
        public Vector2 target => _target;

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
