using System;
using UnityEngine;

namespace Assets.Src.Domains.Models
{
    /// <summary>
    /// 現在地情報
    /// </summary>
    [Serializable]
    public class Location : IDuplicatable<Location>
    {
        /// <summary>
        /// 現在のエリア情報
        /// </summary>
        [SerializeField]
        Area _area = default(Area);
        /// <summary>
        /// 現在のエリア情報
        /// </summary>
        public Area area { get { return _area; } set { _area = value; } }
        /// <summary>
        /// 現在のマップ状態
        /// </summary>
        [SerializeField]
        Map _map = default(Map);
        /// <summary>
        /// 現在のマップ状態
        /// </summary>
        public Map map { get { return _map; } set { _map = value; } }

        /// <summary>
        /// 地域内での現在座標
        /// </summary>
        [SerializeField]
        Vector2 _coordinate = Vector2.zero;
        /// <summary>
        /// 地域内での現在座標
        /// </summary>
        public Vector2 coordinate { get { return _coordinate; } set { _coordinate = value; } }
        /// <summary>
        /// 上方向の方角
        /// </summary>
        [SerializeField]
        Direction _upwardDirection = Direction.NORTH;
        /// <summary>
        /// 上方向の方角
        /// </summary>
        public Direction upwardDirection { get { return _upwardDirection; } set { _upwardDirection = value; } }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public Location MemberwiseClonePublic() => (Location)MemberwiseClone();
    }
}
