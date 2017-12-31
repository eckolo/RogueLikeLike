using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Npcs
{
    /// <summary>
    /// NPCオブジェクト
    /// </summary>
    public class Npc : NpcStationery, IAdhered
    {
        /// <summary>
        /// 形容詞リスト
        /// </summary>
        public List<Adjective> adjectives { get; set; }

        /// <summary>
        /// 主要形容詞
        /// </summary>
        public Adjective mainAdjective => adjectives.First();

        /// <summary>
        /// 現存在座標
        /// </summary>
        Vector2 _location = Vector2.zero;
        /// <summary>
        /// 現存在座標
        /// </summary>
        public Vector2 location => _location;
    }
}
