using Assets.Src.Models.Area;
using UnityEngine;

namespace Assets.Src.Domains
{
    public partial class GameStates
    {
        /// <summary>
        /// 現在地情報
        /// </summary>
        public class Location
        {
            /// <summary>
            /// 現在のエリア情報
            /// </summary>
            public AreaRoot area { get; set; } = default(AreaRoot);
            /// <summary>
            /// 現在のマップ状態
            /// </summary>
            public Map map { get; set; } = default(Map);

            /// <summary>
            /// 地域内での現在座標
            /// </summary>
            public Vector2 coordinate { get; set; } = Vector2.zero;
            /// <summary>
            /// 上方向の方角
            /// </summary>
            public Direction upwardDirection { get; set; } = Direction.NORTH;
        }
    }
}
