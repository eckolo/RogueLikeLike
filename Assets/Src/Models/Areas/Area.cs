using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Areas
{
    /// <summary>
    /// 地域オブジェクトルート
    /// </summary>
    public class Area : AreaStationery, IAdhered, IDuplicatable<Area>
    {
        /// <summary>
        /// 他地域との接続情報
        /// </summary>
        public IEnumerable<AreaConnection> connectionList { get; set; }

        /// <summary>
        /// 内包するマップのリスト
        /// </summary>
        public Dictionary<Vector2, Map> includeMapList { get; set; }

        /// <summary>
        /// 形容詞リスト
        /// </summary>
        public List<Adjective> adjectives { get; set; }

        /// <summary>
        /// 主要形容詞
        /// </summary>
        public Adjective mainAdjective => adjectives.First();

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public Area MemberwiseClonePublic() => (Area)MemberwiseClone();
    }
}
