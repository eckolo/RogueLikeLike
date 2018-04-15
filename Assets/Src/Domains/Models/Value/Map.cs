using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Interface;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// マップオブジェクト
    /// </summary>
    public class Map : IDuplicatable<Map>
    {
        /// <summary>
        /// 発生イベント
        /// </summary>
        [SerializeField]
        MapEvent _occurMapEvent;
        /// <summary>
        /// 発生イベント
        /// </summary>
        public MapEvent occurMapEvent { get { return _occurMapEvent; } set { _occurMapEvent = value; } }

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
        public Dictionary<Vector2, Npc> npcList { get { return _npcList; } set { _npcList = value; } }

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
