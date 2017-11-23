using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Src.Models.Item;

namespace Assets.Src.Models
{
    /// <summary>
    /// アイテムオブジェクト
    /// </summary>
    public class ItemRoot : ItemStationery, IAdhered
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
