using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アイテムオブジェクト
    /// </summary>
    [Serializable]
    public partial class Item : Adhered<ItemStationery>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        /// <param name="adjectives">付与形容詞</param>
        public Item(ItemStationery stationery, List<Adjective> adjectives = null) : base(stationery, adjectives)
        {
        }
    }
}
