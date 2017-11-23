using Assets.Src.Models.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
{
    /// <summary>
    /// アビリティオブジェクト
    /// </summary>
    public class AbilityRoot : AbilityStationery, IAdhered
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
