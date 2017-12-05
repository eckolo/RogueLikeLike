using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models.Area
{
    /// <summary>
    /// 地域オブジェクトルート
    /// </summary>
    public class AreaRoot : AreaStationery, IAdhered
    {
        /// <summary>
        /// 他地域との接続情報
        /// </summary>
        public List<AreaConnection> connectionList { get; set; }
        /// <summary>
        /// 内包するマップのリスト
        /// </summary>
        public List<Map> includeMapList { get; set; }

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
