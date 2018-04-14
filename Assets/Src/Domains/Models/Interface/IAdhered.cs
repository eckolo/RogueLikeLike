using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;

namespace Assets.Src.Domains.Models.Interface
{
    /// <summary>
    /// 形容されたオブジェクトの雛形
    /// </summary>
    public interface IAdhered
    {
        /// <summary>
        /// 形容詞リスト
        /// </summary>
        List<Adjective> adjectives { get; set; }
        /// <summary>
        /// 主要形容詞
        /// </summary>
        Adjective mainAdjective { get; }
    }
}
