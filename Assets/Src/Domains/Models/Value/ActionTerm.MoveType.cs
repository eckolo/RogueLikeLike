namespace Assets.Src.Domains.Models.Value
{
    public partial class ActionTerm
    {
        /// <summary>
        /// 移動方針タイプ
        /// </summary>
        public enum MoveType
        {
            /// <summary>
            /// 移動しない
            /// </summary>
            NONE,
            /// <summary>
            /// ランダム移動
            /// </summary>
            RANDOM,
            /// <summary>
            /// 接近
            /// </summary>
            APPROACH,
            /// <summary>
            /// 遠ざかる
            /// </summary>
            GO_AWAY,
            /// <summary>
            /// 距離を維持する
            /// </summary>
            MAINTAIN_DISTANCE
        }
    }
}
