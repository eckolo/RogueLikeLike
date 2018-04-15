using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
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
        /// 現在のマップ情報
        /// </summary>
        public Map nowMap
        {
            get {
                if(!includeMapList.ContainsKey(_nowMapCondition)) return null;
                return includeMapList[_nowMapCondition];
            }
            set {
                if(!includeMapList.ContainsValue(value)) return;
                _nowMapCondition = includeMapList.Single(map => map.Value == value).Key;
            }
        }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        [SerializeField]
        Vector2 _nowMapCondition = Vector2.zero;
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        public Vector2 nowMapCondition { get { return _nowMapCondition; } set { _nowMapCondition = value; } }

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
