using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Src.Domains.Models.Entity
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
