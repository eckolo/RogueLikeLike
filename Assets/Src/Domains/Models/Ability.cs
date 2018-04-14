using System.Collections.Generic;
using System.Linq;

namespace Assets.Src.Domains.Models
{
    /// <summary>
    /// アビリティオブジェクト
    /// </summary>
    public class Ability : AbilityStationery, IAdhered
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
