using Assets.Src.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Area
{
    /// <summary>
    /// マップオブジェクト
    /// </summary>
    public class Map
    {
        /// <summary>
        /// 地域内座標
        /// </summary>
        public Vector2 coordinate { get; set; }

        /// <summary>
        /// 発生イベント
        /// </summary>
        public MapEvent occurMapEvent { get; set; }

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
    }
}
