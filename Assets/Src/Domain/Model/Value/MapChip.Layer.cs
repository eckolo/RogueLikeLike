namespace Assets.Src.Domain.Model.Value
{
    public partial class MapChip
    {
        /// <summary>
        /// マップチップの設置座標Z軸基準値
        /// </summary>
        enum Layer
        {
            /// <summary>
            /// 上層
            /// </summary>
            upper = 20,
            /// <summary>
            /// 下層
            /// </summary>
            under = 10,
            /// <summary>
            /// 地形
            /// </summary>
            terrain = 0
        }
    }
}
