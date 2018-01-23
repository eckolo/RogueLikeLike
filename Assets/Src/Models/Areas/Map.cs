using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Models.Areas
{
    /// <summary>
    /// マップオブジェクト
    /// </summary>
    public class Map : IDuplicatable<Map>
    {
        /// <summary>
        /// 発生イベント
        /// </summary>
        public MapEvent occurMapEvent { get; set; }

        /// <summary>
        /// 各マスのマップチップリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// z座標が大きいほど手前に表示
        /// </summary>
        public Dictionary<Vector3, MapChip> mapchipList { get; set; }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public Map MemberwiseClonePublic() => (Map)MemberwiseClone();
    }
}
