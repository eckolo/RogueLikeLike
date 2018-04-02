using Assets.Src.Models;
using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// ゲーム状態の実体を表すインターフェース
    /// </summary>
    public interface IStateEntity : IDuplicatable<IStateEntity>
    {
        /// <summary>
        /// 現在の所在地情報
        /// </summary>
        Location location { get; set; }

        /// <summary>
        /// 各マスのNPCリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// </summary>
        Dictionary<Vector2, Npc> npcList { get; set; }

        /// <summary>
        /// 行動履歴
        /// </summary>
        List<Happened> happenedLog { get; set; }

        /// <summary>
        /// 現在の行動者
        /// </summary>
        Npc actor { get; set; }
    }
}
