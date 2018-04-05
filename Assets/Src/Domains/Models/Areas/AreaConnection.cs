using UnityEngine;

namespace Assets.Src.Domains.Models.Areas
{
    /// <summary>
    /// 地域接続データオブジェクト
    /// </summary>
    public class AreaConnection
    {
        /// <summary>
        /// 地域内座標
        /// </summary>
        public Vector2 coordinate { get; set; }
        /// <summary>
        /// 接続先地域
        /// </summary>
        public Area connectArea { get; set; }
        /// <summary>
        /// 接続先地域の接続座標
        /// </summary>
        public Vector2 connectAreaCoordinate { get; set; }
    }
}
