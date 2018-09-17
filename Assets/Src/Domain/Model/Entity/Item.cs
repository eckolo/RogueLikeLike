using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Model.Value;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domain.Model.Entity
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
