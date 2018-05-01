using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Interface;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// マップオブジェクト
    /// </summary>
    [Serializable]
    public class Map : IDuplicatable<Map>
    {
        /// <summary>
        /// マップの縦横座標絶対値の最大値
        /// </summary>
        [SerializeField]
        Vector2 _coordinateLimit = Vector2.one;
        /// <summary>
        /// マップの縦横座標絶対値の最大値
        /// </summary>
        public Vector2 coordinateLimit => _coordinateLimit;
        /// <summary>
        /// マップの縦横サイズ
        /// </summary>
        public Vector2 size => _coordinateLimit * 2 - Vector2.one;

        /// <summary>
        /// 発生イベント
        /// </summary>
        [SerializeField]
        MapEvent _occurEvent;
        /// <summary>
        /// 発生イベント
        /// </summary>
        public MapEvent occurEvent { get { return _occurEvent; } set { _occurEvent = value; } }

        /// <summary>
        /// 各マスのNPCリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// </summary>
        [SerializeField]
        Dictionary<Vector2, Npc> _npcList;
        /// <summary>
        /// 各マスのNPCリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// </summary>
        public virtual Dictionary<Vector2, Npc> npcList
        {
            get { return _npcList; }
            set { _npcList = value; }
        }

        /// <summary>
        /// 各マスのマップチップリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// z座標が大きいほど手前に表示
        /// </summary>
        [SerializeField]
        Dictionary<Vector3, MapChip> _mapchipList;
        /// <summary>
        /// 各マスのマップチップリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// z座標が大きいほど手前に表示
        /// </summary>
        public Dictionary<Vector3, MapChip> mapchipList { get { return _mapchipList; } set { _mapchipList = value; } }

        /// <summary>
        /// マップが初期状態であるか否か
        /// </summary>
        [SerializeField]
        bool _isInitialState = true;
        /// <summary>
        /// マップが初期状態であるか否か
        /// </summary>
        public bool isInitialState { get { return _isInitialState; } set { _isInitialState = value; } }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public Map MemberwiseClonePublic() => (Map)MemberwiseClone();
    }
}
