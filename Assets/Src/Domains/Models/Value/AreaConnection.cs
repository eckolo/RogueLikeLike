using Assets.Src.Domains.Models.Entity;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 地域接続データオブジェクト
    /// </summary>
    public class AreaConnection
    {
        /// <summary>
        /// 地域内座標
        /// </summary>
        [SerializeField]
        public Vector2 coordinate { get; set; }
        /// <summary>
        /// 接続先地域
        /// </summary>
        [SerializeField]
        public Area connectArea { get; set; }
        /// <summary>
        /// 接続先地域の接続座標
        /// </summary>
        [SerializeField]
        public Vector2 connectAreaCoordinate { get; set; }
    }
}
