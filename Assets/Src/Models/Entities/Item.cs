using UnityEngine;
using System.Collections;
using Assets.Src.Models.Values;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Src.Models.Entities
{
    /// <summary>
    /// アイテムオブジェクト
    /// </summary>
    public class Item : ItemStationery, IAdhered
    {
        /// <summary>
        /// 形容詞リスト
        /// </summary>
        public List<Adjective> adjectives { get; set; }

        /// <summary>
        /// 主要形容詞
        /// </summary>
        public Adjective mainAdjective => adjectives.First();
    }
}
