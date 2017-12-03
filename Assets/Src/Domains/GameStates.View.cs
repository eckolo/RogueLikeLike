using Assets.Src.Models;
using Assets.Src.Models.Area;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains
{
    public partial class GameStates
    {
        /// <summary>
        /// 画面表示状態の保持
        /// </summary>
        public class View
        {
            /// <summary>
            /// 各マスのマップチップリスト
            /// 座標は中央が(0,0)、東がx+1、北がY+1
            /// マップチップ配列はインデックスが多いほど手前に表示
            /// </summary>
            public Dictionary<Vector2, List<MapChip>> mapchipList { get; set; }

            /// <summary>
            /// 各マスのNPCリスト
            /// 座標は中央が(0,0)、東がx+1、北がY+1
            /// </summary>
            public Dictionary<Vector2, Npc> npcList { get; set; }

            /// <summary>
            /// 描画の更新用全オブジェクトの今回の行動リスト
            /// </summary>
            public List<KeyValuePair<Npc, BehaviorHistory>> updateList { get; set; }
        }
    }
}
