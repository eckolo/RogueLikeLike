using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Model.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domain.Model.Entity
{
    /// <summary>
    /// 地域オブジェクトルート
    /// </summary>
    [Serializable]
    public partial class Area : Adhered<AreaStationery>, IDuplicatable<Area>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        /// <param name="adjectives">付与形容詞</param>
        /// <param name="connectionList">他地域との接続情報</param>
        public Area(
            AreaStationery stationery,
            List<Adjective> adjectives = null,
            IEnumerable<AreaConnection> connectionList = null)
            : base(stationery, adjectives)
        {
            this.connectionList = connectionList ?? this.connectionList;
        }

        /// <summary>
        /// エリアの広さ（マップ数単位）
        /// </summary>
        [SerializeField]
        Vector2 _areaRange = default;
        /// <summary>
        /// エリアの広さ（マップ数単位）
        /// </summary>
        public Vector2 areaRange => _areaRange;

        /// <summary>
        /// 他地域との接続情報
        /// </summary>
        [SerializeField]
        IEnumerable<AreaConnection> _connectionList = Enumerable.Empty<AreaConnection>();
        /// <summary>
        /// 他地域との接続情報
        /// </summary>
        public IEnumerable<AreaConnection> connectionList
        {
            get { return _connectionList; }
            set { _connectionList = value; }
        }

        /// <summary>
        /// 内包するマップのリスト
        /// </summary>
        [SerializeField]
        Dictionary<Vector2, Map> _includeMapList = new Dictionary<Vector2, Map>();
        /// <summary>
        /// 内包するマップのリスト
        /// </summary>
        public Dictionary<Vector2, Map> includeMapList
        {
            get { return _includeMapList; }
            set { _includeMapList = value; }
        }

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
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public Area MemberwiseClonePublic() => (Area)MemberwiseClone();
    }
}
