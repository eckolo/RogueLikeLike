namespace Assets.Src.Domain.Model.Value
{
    public partial class Ailment
    {
        /// <summary>
        /// 状態異常の作動タイミング
        /// </summary>
        public enum OperationTiming
        {
            /// <summary>
            /// 発生時
            /// </summary>
            OCCURRENCE,
            /// <summary>
            /// 行動前
            /// </summary>
            BEFORE_ACTION,
            /// <summary>
            /// 行動後
            /// </summary>
            AFTER_ACTION,
            /// <summary>
            /// 被弾前
            /// </summary>
            BEFORE_HITTING,
            /// <summary>
            /// 被弾後
            /// </summary>
            AFTER_HITTING,
            /// <summary>
            /// 解除時
            /// </summary>
            RELEASED,
        }
    }
}
