﻿using Assets.Src.Models;
using Assets.Src.Models.Npcs;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains
{
    public partial class GameStates
    {
        /// <summary>
        /// メインパラメータ
        /// </summary>
        class Parameters
        {
            /// <summary>
            /// 現在の所在地情報
            /// </summary>
            public Location location { get; set; } = new Location();

            /// <summary>
            /// 各マスのNPCリスト
            /// 座標は中央が(0,0)、東がx+1、北がY+1
            /// </summary>
            public Dictionary<Vector2, Npc> npcList { get; set; } = new Dictionary<Vector2, Npc>();

            /// <summary>
            /// 行動履歴
            /// </summary>
            public List<Happened> happenedLog { get; set; } = new List<Happened>();

            /// <summary>
            /// 現在の行動者
            /// </summary>
            public Npc actor { get; set; } = null;
        }
    }
}
