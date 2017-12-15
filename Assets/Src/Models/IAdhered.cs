using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
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
